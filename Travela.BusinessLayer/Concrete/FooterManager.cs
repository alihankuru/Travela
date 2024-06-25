using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.EntityFramework;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete
{
    public class FooterManager : IFooterService
    {
        private readonly IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void TDelete(int id)
        {
            _footerDal.Delete(id);
        }

        public Footer TGetById(int id)
        {
            return _footerDal.GetById(id);
        }

        public List<Footer> TGetListAll()
        {
            return _footerDal.GetListAll();
        }

        public void TInsert(Footer entity)
        {
            _footerDal.Insert(entity);
        }

        public void TUpdate(Footer entity)
        {
            _footerDal.Update(entity);
        }
    }
}
