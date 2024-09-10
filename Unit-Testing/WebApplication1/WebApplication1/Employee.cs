namespace Main{
public class Employee
{
    
    private string _cpr;    
    private string _name;
    private string _surName;
    private string _fullName => $"{_name} {_surName}";
    //Date of birth
    private DateTime _dob;
    
    private Department _department;  

    private decimal _baseSalary;

    private EducationalLevel _educationalLevel;

    private DateTime _date_of_employment;
    private string _country;
    

    public Employee(string cpr,
    string name, 
    string surName, 
    DateTime dob, 
    Department department,
    decimal baseSalary, 
    EducationalLevel educationalLevel, 
    DateTime date_of_employment, 
    string country)
    {
        
        if(cpr.Length != 10){
            throw new ArgumentException("CPR must be 10 characters long");
        }else{
            _cpr = cpr;
        }

        if(name.Length < 1 || surName.Length < 1){
            throw new ArgumentException("Name must be at least 1 characters long");
        }else if(name.Length > 30 || surName.Length > 30){
            throw new ArgumentException("Name must be at most 30 characters long");
        }else{
            _name = name;
            _surName = surName;
        }
        
        var validDepartment = Enum.IsDefined(typeof(Department), department);

        if (!validDepartment)
        {
            throw new ArgumentException("Department must be one of the following: IT, HR, Finance, Sales, General_Services");
        }
        else{
            _department = department;
        }

        if(dob > DateTime.Now){
            throw new ArgumentException("Date of birth must be in the past");
        }else if(dob < DateTime.Now.AddYears(-18)){
            throw new ArgumentException("Date of birth must be within the last 120 years");
        }else{
            _dob = dob;
        }

        if (baseSalary < 20000 || baseSalary > 100000)
        {
            throw new ArgumentException("Base salary must be within 20000 and 100000");
        }
        else
        {
            _baseSalary = baseSalary;
        }

        if (educationalLevel < EducationalLevel.None || educationalLevel > EducationalLevel.Tertiary)
        {
            throw new ArgumentException("Educational level must be between 0 and 3");
        }
        else
        {
            _educationalLevel = educationalLevel;
        }
        
        if(date_of_employment > DateTime.Now){
            throw new ArgumentException("Date of employment must be in the past");
        }else if(date_of_employment < DateTime.Now.AddYears(-120)){
            throw new ArgumentException("Date of employment must be within the last 120 years");
        }else{
            _date_of_employment = date_of_employment;
        }
        
        _country = country;
    }



    public decimal GetSalary()
    {
        return _baseSalary + ((int)_educationalLevel * 1220);
    }

    public decimal GetDiscount()
    {
        var datenow = DateTime.Now;
        var timeEmployed = datenow - _date_of_employment;
        var years = Math.Floor((double)timeEmployed.Days / 365);
        var discount = (decimal)years * 0.5m;

        return discount;
    }

    public decimal GetShippingCosts()
    {
        var freeShipping = new List<string> { "Denmark", "Sweden", "Norway" };
        var fiftyShipping = new List<string> { "Finland", "Iceland" };

        if (freeShipping.Contains(_country))
        {
            return 0;
        }
        else if (fiftyShipping.Contains(_country))
        {
            return 5.0m;
        }
        else
        {
            return 1;
        }
    }
 }
}
