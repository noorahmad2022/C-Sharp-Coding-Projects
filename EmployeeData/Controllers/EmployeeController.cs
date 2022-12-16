
using EmployeeData.DAL;
using Microsoft.AspNetCore.Mvc;
using EmployeeData.Models.DbEntities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeData.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly empDbContext context;

        public EmployeeController(empDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var employee = context.employees.ToList();
            return View(employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employeeData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employee = new Employee()
                    {
                        firstName = employeeData.firstName,
                        lastName = employeeData.lastName,
                        dateOfBirth = employeeData.dateOfBirth,
                        Status = employeeData.Status,
                        Email = employeeData.Email,
                        contactNumber = employeeData.contactNumber,
                        Salary = employeeData.Salary
                    };
                    context.employees.Add(employee);
                    context.SaveChanges();
                    TempData["SuccessMessage"] = "Employee Added Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Employee data is not valid. ";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult View(int Id)
        {
            try
            {
                var employee = context.employees.SingleOrDefault(x => x.Id == Id);
                if (employee != null)
                {
                    var employees = new Employee()
                    {
                        Id = employee.Id,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        dateOfBirth = employee.dateOfBirth,
                        Status = employee.Status,
                        Email = employee.Email,
                        contactNumber = employee.contactNumber,
                        Salary = employee.Salary
                    };
                    return View(employees);
                }
                else
                {
                    TempData["errorMessage"] = $"Employee details not available with the ID: {Id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            try
            {
                var employee = context.employees.SingleOrDefault(x => x.Id == Id);
                if (employee != null)
                {
                    var employees = new Employee()
                    {
                        Id = employee.Id,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        dateOfBirth = employee.dateOfBirth,
                        Status = employee.Status,
                        Email = employee.Email,
                        contactNumber = employee.contactNumber,
                        Salary = employee.Salary
                    };
                    return View(employees);
                }
                else
                {
                    TempData["errorMessage"] = $"Employee details not available with the ID: {Id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employee = new Employee()
                    {
                        Id = model.Id,
                        firstName = model.firstName,
                        lastName = model.lastName,
                        dateOfBirth = model.dateOfBirth,
                        Status = model.Status,
                        Email = model.Email,
                        contactNumber = model.contactNumber,
                        Salary = model.Salary
                    };
                    context.employees.Update(employee);
                    context.SaveChanges();

                    TempData["SuccessMessage"] = "Employee Details updated Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = $"Employee details is invaled";
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            try
            {
                var employee = context.employees.SingleOrDefault(x => x.Id == Id);
                if (employee != null)
                {
                    var employees = new Employee()
                    {
                        Id = employee.Id,
                        firstName = employee.firstName,
                        lastName = employee.lastName,
                        dateOfBirth = employee.dateOfBirth,
                        Status = employee.Status,
                        Email = employee.Email,
                        contactNumber = employee.contactNumber,
                        Salary = employee.Salary
                    };
                    return View(employees);
                }
                else
                {
                    TempData["errorMessage"] = $"Employee details not available with the ID: {Id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(Employee model)
        {
            try
            {
                var employee = context.employees.SingleOrDefault(x => x.Id == model.Id);
                if (employee != null)
                {
                    context.employees.Remove(employee);
                    context.SaveChanges();
                    TempData["SuccessMessage"] = "Employee deleted successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = $"Employee details not available with the ID : {model.Id}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }
    }
}



