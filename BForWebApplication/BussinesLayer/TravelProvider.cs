using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    //public class TravelProvider
    //{
    //    public static Create
    //    public static List<Passenger> GetAllPassengers(int companyID, int travelID)
    //    {
    //        List<Passenger> pas_lst = null;
    //        using (BForEntities dbc_cntxt = new BForEntities())
    //        {
    //            pas_lst = (from travelpass in dbc_cntxt.TravelPlannedPassengers
    //                       join p in dbc_cntxt.CompanyPassengers on travelpass.CompanyPassengerID equals p.CompanyPassengerID
    //                       join c in dbc_cntxt.Companies on p.CompanyID equals c.CompanyID
    //                       where travelpass.TravelPlannedID == travelID 
    //                       where p.CompanyID == companyID
    //                       select p.Passenger).ToList();
    //        }

    //        return pas_lst;
    //    }

        
    //    public static object GetAllCars()
    //    {
    //        //List<Car> car_lst = null;
    //        object car_lst = null;
    //        using (BForEntities dbc_cntxt = new BForEntities())
    //        {
    //            car_lst = (from compcar in dbc_cntxt.ComapyCars
    //                       //join cars in dbc_cntxt.Cars on  compcar.Car.t_CarBrands.t_CarType..
    //                       //join carbrnd in dbc_cntxt.Cars on
    //                       //join cartyp in dbc_cntxt.Cars on
    //                       group compcar by new { compcar.Company.CompanyID, CompName = compcar.Company.Name, compcar.Car.t_CarBrands.t_CarType.CarTypeID, CarTypeName = compcar.Car.t_CarBrands.t_CarType.Name, compcar.Car.t_CarBrands.t_CarType.PassengersCapacity } into cct
    //                       select new
    //                       {
    //                           cct.Key.CompanyID,
    //                           cct.Key.CompName,
    //                           cct.Key.CarTypeID,
    //                           cct.Key.CarTypeName,
    //                           cct.Key.PassengersCapacity,
    //                           carsNo = cct.Count(),
    //                       }).ToList();
    //        };

    //        return car_lst;
    //    }

    //}
}
