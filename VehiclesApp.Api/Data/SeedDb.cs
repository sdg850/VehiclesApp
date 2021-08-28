using System;
using System.Linq;
using System.Threading.Tasks;
//using Vehicles.API.Data.Entities;
//using Vehicles.API.Helpers;
//using Vehicles.Common.Enums;
using VehiclesApp.Api.Data;
using VehiclesApp.Api.Data.Entities;

namespace Vehicles.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        //private readonly IUserHelper _userHelper;

        //public SeedDb(DataContext context, IUserHelper userHelper)
        //{
        //    _context = context;
        //    _userHelper = userHelper;
        //}
        public SeedDb(DataContext context )
        {
            _context = context;
            
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiclesTypeAsync();
            await CheckBrandsAsync();
            await CheckDocumentTypesAsync();
            await CheckProceduresAsync();
            //await checkrolesasycn();
            //await checkuserasync("1010", "luis", "salazar", "luis@yopmail.com", "311 322 4620", "calle luna calle sol", usertype.admin);
            //await checkuserasync("2020", "juan", "zuluaga", "zulu@yopmail.com", "311 322 4620", "calle luna calle sol", usertype.user);
            //await checkuserasync("3030", "ledys", "bedoya", "ledys@yopmail.com", "311 322 4620", "calle luna calle sol", usertype.user);
            //await checkuserasync("4040", "sandra", "lopera", "sandra@yopmail.com", "311 322 4620", "calle luna calle sol", usertype.admin);
        }

        //private async task checkuserasync(string document, string firstname, string lastname, string email, string phonenumber, string address, usertype usertype)
        //{
        //    user user = await _userhelper.getuserasync(email);
        //    if (user == null)
        //    {
        //        user = new user
        //        {
        //            address = address,
        //            document = document,
        //            documenttype = _context.documenttypes.firstordefault(x => x.description == "cédula"),
        //            email = email,
        //            firstname = firstname,
        //            lastname = lastname,
        //            phonenumber = phonenumber,
        //            username = email,
        //            usertype = usertype
        //        };

        //        await _userhelper.adduserasync(user, "123456");
        //        await _userhelper.addusertoroleasync(user, usertype.tostring());

        //        string token = await _userhelper.generateemailconfirmationtokenasync(user);
        //        await _userhelper.confirmemailasync(user, token);
        //    }
        //}

        //private async task checkrolesasycn()
        //{
        //    await _userhelper.checkroleasync(usertype.admin.tostring());
        //    await _userhelper.checkroleasync(usertype.user.tostring());
        //}

        private async Task CheckProceduresAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lubricación de suspención trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido frenos delanteros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Líquido frenos traseros" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Calibración de válvulas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Alineación carburador" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Aceite caja" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Filtro de aire" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Sistema eléctrico" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Guayas" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta delantera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio llanta trasera" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Reparación de motor" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Kit arrastre" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Banda transmisión" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio batería" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavado sistema de inyección" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Lavada de tanque" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio de bujia" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento delantero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Cambio rodamiento trasero" });
                _context.Procedures.Add(new Procedure { Price = 10000, Description = "Accesorios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckDocumentTypesAsync()
        {
            if (!_context.DocumentsType.Any())
            {
                _context.DocumentsType.Add(new DocumentsType { Description = "Cédula" });
                _context.DocumentsType.Add(new DocumentsType { Description = "Tarjeta de Identidad" });
                _context.DocumentsType.Add(new DocumentsType { Description = "NIT" });
                _context.DocumentsType.Add(new DocumentsType { Description = "Pasaporte" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckBrandsAsync()
        {
            if (!_context.Brands.Any())
            {
                _context.Brands.Add(new Brand { Description = "Ducati" });
                _context.Brands.Add(new Brand { Description = "Harley Davidson" });
                _context.Brands.Add(new Brand { Description = "KTM" });
                _context.Brands.Add(new Brand { Description = "BMW" });
                _context.Brands.Add(new Brand { Description = "Triumph" });
                _context.Brands.Add(new Brand { Description = "Victoria" });
                _context.Brands.Add(new Brand { Description = "Honda" });
                _context.Brands.Add(new Brand { Description = "Suzuki" });
                _context.Brands.Add(new Brand { Description = "Kawasaky" });
                _context.Brands.Add(new Brand { Description = "TVS" });
                _context.Brands.Add(new Brand { Description = "Bajaj" });
                _context.Brands.Add(new Brand { Description = "AKT" });
                _context.Brands.Add(new Brand { Description = "Yamaha" });
                _context.Brands.Add(new Brand { Description = "Chevrolet" });
                _context.Brands.Add(new Brand { Description = "Mazda" });
                _context.Brands.Add(new Brand { Description = "Renault" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehiclesTypeAsync()
        {
            if (!_context.VehiclesType.Any())
            {
                _context.VehiclesType.Add(new VehiclesType { Description = "Carro" });
                _context.VehiclesType.Add(new VehiclesType { Description = "Moto" });
                await _context.SaveChangesAsync();
            }
        }
    }
}