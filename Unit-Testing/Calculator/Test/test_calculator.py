from app.calculator import Calculator


#AAA Method
# Arrange: Set up the object and the values
# Act: Call the method to be tested
# Assert: Check the result of the method

def test_sum(): #Positive Test Case
    # Arrange
    calc = Calculator(3, 5)
    # Act
    result = calc.sum()
    # Assert
    assert result == 8

def test_sum(): #Negative Test Case
    # Arrange
    calc = Calculator(3, 5)
    # Act
    result = calc.sum()
    # Assert
    assert result != 9

#
# Positive Test Cases
#
def test_sum():
    calc = Calculator(3, 5)
    assert calc.sum() == 8

def test_subtract():
    calc = Calculator(10, 5)
    assert calc.subtract() == 5

def test_multiply():
    calc = Calculator(3, 5)
    assert calc.multiply() == 15

def test_divide():
    calc = Calculator(10, 5)
    assert calc.divide() == 2

#
# Negative Test Cases
#
def test_sum_negative():
    calc = Calculator(3, 5)
    assert calc.sum() != 9

def test_subtract_negative():
    calc = Calculator(10, 5)
    assert calc.subtract() != 6
    
def test_multiply_negative():
    calc = Calculator(3, 5)
    assert calc.multiply() != 20

def test_divide_negative():   
    calc = Calculator(10, 5)
    assert calc.divide() != 3