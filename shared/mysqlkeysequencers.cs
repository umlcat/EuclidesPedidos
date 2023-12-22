using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EuclidesPedidos.Models;
using MySql.Data.MySqlClient;
using Dapper;

namespace EuclidesPedidos.shared
{
    public class MySQLKeySequencer : DBSQLDBKeySequencer
    {
        #region "properties"

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        #endregion

        #region "constructor"

        public MySQLKeySequencer()
        {
            this.ServerName = "";
            this.DatabaseName = "";
            this.UserName = "";
            this.Password = "";
        }

        #endregion

        public override bool /* ## func */ CanConnect()
        {
            bool Result =
                true
                && (!String.IsNullOrEmpty(this._TableName))
                && (!String.IsNullOrEmpty(this._FieldName))
                && (!String.IsNullOrEmpty(this.ServerName))
                && (!String.IsNullOrEmpty(this.DatabaseName))
                && (!String.IsNullOrEmpty(this.UserName))
                && (!String.IsNullOrEmpty(this.Password))
                ;
            return Result;
        } // func

        // ...

    } // class

    public class MySQLIntKeySequencer : MySQLKeySequencer
    {

        #region "constructor"

        public MySQLIntKeySequencer()
        {
            //this._Context = null;
        }

        #endregion

        #region "getters"

        public override bool /* ## func */ TryGetAsInteger
          (out int /* ## param */ ADest)
        {
            bool Result = false;

            /* ## out */ ADest = 0;

            // ---

            if (this.CanConnect())
            {
                string ConnectionTemplate =
                    @"Server={0};Database={1};Uid={2};Pwd={3};";
                //MessageBox.Show("ConnectionTemplate:" + ConnectionTemplate);

                string Connection =
                    String.Format(ConnectionTemplate, this.ServerName, this.DatabaseName, this.UserName, this.Password);
                //MessageBox.Show("Connection:" + Connection);

                // ---

                string SQLTemplate =
                    "SELECT MAX({1}) AS ID FROM {0}";
                //MessageBox.Show("SQLTemplate:" + SQLTemplate);

                string SQLQuery =
                    String.Format(SQLTemplate, this.TableName, this.FieldName);
                //MessageBox.Show("SQLQuery:" + SQLQuery);

                // ---

                IEnumerable<int> List = null;

                using (var DB = new MySqlConnection(Connection))
                {
                    List = DB.Query<int>(SQLQuery);

                    ADest =
                        List.AsList().FirstOrDefault();
                    //MessageBox.Show(AResult.ToString());
                } // using
            } // if

            // ---
            return Result;
        } // func

        #endregion

        #region "setters"

        public override bool /* ## func */ TrySetAsInteger
          (in int /* ## param */ ASource)
        {
            bool Result = false;
            // ---

            if (this.CanConnect())
            {
                string ConnectionTemplate =
                    @"Server={0};Database={1};Uid={2};Pwd={3};";
                //MessageBox.Show("ConnectionTemplate:" + ConnectionTemplate);

                string Connection =
                    String.Format(ConnectionTemplate, this.ServerName, this.DatabaseName, this.UserName, this.Password);
                //MessageBox.Show("Connection:" + Connection);

                // ---

                string SQLTemplate =
                    "UPDATE {0} SET {1} = @value";
                //MessageBox.Show("SQLTemplate:" + SQLTemplate);

                string SQLQuery =
                    String.Format(SQLTemplate, this.TableName, this.FieldName);
                //MessageBox.Show("SQLQuery:" + SQLQuery);

                // ---

                using (var DB = new MySqlConnection(Connection))
                {
                    DB.ExecuteScalar(SQLQuery, ASource);
                    //MessageBox.Show(AResult.ToString());
                } // using            
            } // if

            // ---
            return Result;
        } // func

        #endregion

        protected override int /* ## func */ InternalUpdateAsInt()
        {
            int Result = 0;

            // get curret max value plus one
            Result =
                (this.AsInteger + 1);

            this.TrySetAsInteger(Result);

            // ---

            return Result;
        } // func

        // ...

    } // class

    // ...

} // namespace


