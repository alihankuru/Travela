using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete
{
    public class PackageManager : IPackageService
    {
        private readonly IPackageDal _packageDal;

        public PackageManager(IPackageDal PackageDal)
        {
            _packageDal = PackageDal;
        }

        public void TDelete(int id)
        {
            _packageDal.Delete(id);
        }

        public Package TGetById(int id)
        {
            return _packageDal.GetById(id);
        }

        public List<Package> TGetListAll()
        {
            return _packageDal.GetListAll();
        }

        public void TInsert(Package entity)
        {
            _packageDal.Insert(entity);
        }

        public void TUpdate(Package entity)
        {
            _packageDal.Update(entity);
        }
    }
}
