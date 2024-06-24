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
    public class CarouselManager : ICarouselService
    {
        private readonly ICarouselDal _carouselDal;

        public CarouselManager(ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }

        public void TDelete(int id)
        {
            _carouselDal.Delete(id);
        }

        public Carousel TGetById(int id)
        {
            return _carouselDal.GetById(id);
        }

        public List<Carousel> TGetListAll()
        {
            return _carouselDal.GetListAll();
        }

        public void TInsert(Carousel entity)
        {
            _carouselDal.Insert(entity);
        }

        public void TUpdate(Carousel entity)
        {
            _carouselDal.Update(entity);
        }
    }
}
