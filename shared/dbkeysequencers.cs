using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EuclidesPedidos.shared
{
    public abstract class DBKeySequencer : IDisposable
    {
        #region "constructor"

        public DBKeySequencer()
        {
            //
        }

        #endregion

        #region "destructor"

        private bool _disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DBKeySequencer()
        {
            Dispose(false);
        }

        #endregion

        #region "getters"

        public virtual bool /* ## func */ TryGetAsInteger
          (out int /* ## param */ ADest)
        {
            ADest = 0;
            return true;
        } // func

        public virtual bool /* ## func */ TryGetAsGuid
          (out Guid /* ## param */ ADest)
        {
            ADest = Guid.Empty;
            return true;
        } // func

        #endregion

        #region "setters"

        public virtual bool /* ### func */ TrySetAsInteger
          (in int /* ## param */ ASource)
        {
            return true;
        } // func

        public virtual bool /* ### func */ TrySetAsGuid
          (in Guid /* ## param */ ASource)
        {
            return true;
        } // func

        #endregion

        #region "properties"

        public int /* ## prop */ AsInteger
        {
            get
            {
                int ADest = 0;
                TryGetAsInteger(out ADest);
                return ADest;
            }
            set
            {
                int ASource = 0;
                TrySetAsInteger(in ASource);
                value = ASource;
            }
        } // prop

        public Guid /* ## prop */ AsGuid
        {
            get
            {
                Guid ADest = Guid.Empty;
                TryGetAsGuid(out ADest);
                return ADest;
            }
            set
            {
                Guid ASource = Guid.Empty;
                TrySetAsGuid(in ASource);
                value = ASource;
            }
        } // prop


        #endregion

        protected virtual int /* ## func */ InternalUpdateAsInt()
        {
            int Result = 0;
            // ---

            // DoNothing();

            // ---
            return Result;
        } // func

        protected virtual Guid /* ## func */ InternalUpdateAsGuid()
        {
            Guid Result = Guid.Empty;
            // ---

            // DoNothing();

            // ---
            return Result;
        } // func

        // ---

        public abstract bool /* ## func */ CanConnect();

        public int /* ## nonvirtual func */ UpdateAsInt()
        {
            int Result = 0;
            // ---

            Result =
                InternalUpdateAsInt();

            // ---
            return Result;
        } // func

        public Guid /* ## nonvirtual func */ UpdateAsGuid()
        {
            Guid Result = Guid.Empty;
            // ---

            Result = this.UpdateAsGuid();

            // ---
            return Result;
        } // func

        // ...

    } // class

    public abstract class DBSQLDBKeySequencer : DBKeySequencer
    {
        #region "properties"

        protected string _TableName;
        protected string _FieldName;

        public string TableName { get => _TableName; set => _TableName = value; }
        public string FieldName { get => _FieldName; set => _FieldName = value; }

        #endregion

        #region "constructor"

        public DBSQLDBKeySequencer()
        {
            this._TableName = "";
            this._FieldName = "";
        }

        public DBSQLDBKeySequencer
            (in string ATableName, in string AFieldName)
        {
            this._TableName = ATableName;
            this._FieldName = AFieldName;
        }

        #endregion

        public override bool /* ## func */ CanConnect()
        {
            bool Result =
                (true
                && (!String.IsNullOrEmpty(this._TableName))
                && (!String.IsNullOrEmpty(this._FieldName))
                );
            return Result;
        } // func

        // ...

    } // class

    // ...

} // namespace