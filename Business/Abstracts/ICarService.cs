using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int id);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
