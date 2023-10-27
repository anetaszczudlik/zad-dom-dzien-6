using zad_dom_dzien_6;

Employee employee1 = new Employee("Jadwiga", "Spalina");
Employee employee2 = new Employee("Janusz", "Tracz");
Employee employee3 = new Employee("Kazimiera", "Solejuk");

employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(2);
employee1.AddScore(1);

employee2.AddScore(8);
employee2.AddScore(6);
employee2.AddScore(10);
employee2.AddScore(7);
employee2.AddScore(8);

employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(10);
employee3.AddScore(3);


List<Employee> employees = new List<Employee>()
{ 
    employee1, employee2, employee3 
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z maksymalną liczbą punktów to " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + "," + " " + maxResult + "pkt.");