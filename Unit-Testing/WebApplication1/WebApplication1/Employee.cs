namespace Main{
public class Employee
{
    
    private string _cpr;    
    private string _name;
    private string _surName;
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

    #region Getters and Setters

    public string Cpr{
        get{
            return _cpr;
        }
        set{
            if(value.Length != 10){
                throw new ArgumentException("CPR must be 10 characters long");
            }else if(!value.All(char.IsDigit)){
                throw new ArgumentException("CPR must be a number");
        }else{
                _cpr = value;
            }
        }
    }

    public string Name{
        get{
            return _name;
        }
        set{
            if(value.Length < 1 || value.Length > 30){
                throw new ArgumentException("Name must be at least 1 characters long");
            }else if(value.Length > 30){
                throw new ArgumentException("Name must be at most 30 characters long");
            }else{
                _name = value;
            }
        }
    }

    public string SurName{
        get{
            return _surName;
        }
        set{
            if(value.Length < 1 || value.Length > 30){
                throw new ArgumentException("Surname must be at least 1 characters long");
            }else if(value.Length > 30){
                throw new ArgumentException("Surname must be at most 30 characters long");
            }else{
                _surName = value;
            }
        }
    }

    public DateTime Dob{
        get{
            return _dob;
        }
        set{
            if(value > DateTime.Now){
                throw new ArgumentException("Date of birth must be in the past");
            }else if(value < DateTime.Now.AddYears(-120)){
                throw new ArgumentException("Date of birth must be within the last 120 years");
            }else if(value > DateTime.Now.AddYears(-18)){
                throw new ArgumentException("Date of birth must be at least 18 years ago");
            }else{
                _dob = value;
            }
        }
    }

    public Department Department{
        get{
            return _department;
        }
        set{
            var validDepartment = Enum.IsDefined(typeof(Department), value);

            if (!validDepartment)
            {
                throw new ArgumentException("Department must be one of the following: IT, HR, Finance, Sales, General_Services");
            }
            else{
                _department = value;
            }
        }
    }
    public decimal BaseSalary{
        get{
            return _baseSalary;
        }
        set{
            if (value < 20000 || value > 100000)
            {
                throw new ArgumentException("Base salary must be within 20000 and 100000");
            }
            else
            {
                _baseSalary = value;
            }
        }
    }

    public EducationalLevel EducationalLevel{
        get{
            return _educationalLevel;
        }
        set{
            if (value < EducationalLevel.None || value > EducationalLevel.Tertiary)
            {
                throw new ArgumentException("Educational level must be between 0 and 3");
            }
            else
            {
                _educationalLevel = value;
            }
        }
    }

    public DateTime Date_of_employment{
        get{
            return _date_of_employment;
        }
        set{
            if(value > DateTime.Now){
                throw new ArgumentException("Date of employment must be in the past");
            }else if(value < DateTime.Now.AddYears(-120)){
                throw new ArgumentException("Date of employment must be within the last 120 years");
            }else{
                _date_of_employment = value;
            }
        }
    }
    
    public string Country{
        get{
            return _country;
        }
        set{
            _country = value;
        }
    }

    #endregion

    #region Methods

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

    #endregion

 }
}
