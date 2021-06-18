using MedicineTrackingSystem.BusinessModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MedicineTrackingSystem.DataAccessLayer
{

    public interface IMedicineService : IDisposable
    {
        int Delete(int EmployeeId);
        Medicine GetById(int EmployeeId);
        string Update(Medicine employee);
        int Create(Medicine employee);
        List<Medicine> GetAll();
    }

    public class MedicineService : IMedicineService
    {
        private readonly IDapperHelper _dapperHelper;

        public MedicineService(IDapperHelper dapperHelper)
        {
            this._dapperHelper = dapperHelper;
        }

        public int Delete(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public Medicine GetById(int EmployeeId)
        {
            throw new NotImplementedException();
        }

        public string Update(Medicine employee)
        {
            throw new NotImplementedException();
        }

        public int Create(Medicine employee)
        {
            throw new NotImplementedException();
        }

        public List<Medicine> GetAll()
        {
            var medicines = _dapperHelper.GetAll<Medicine>("SP_Medicine_GetAll", null, commandType: CommandType.StoredProcedure);
            return medicines.ToList();
        }

        #region Dispose

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MedicineFactory()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    
        #endregion
    }
}
