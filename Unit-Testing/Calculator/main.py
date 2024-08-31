from app.calculator import Calculator

num1 = 10
num2 = 5

calc_sum = Calculator(num1, num2)
calc_sub= Calculator(num1, num2)
calc_mul = Calculator(num1, num2)
calc_div = Calculator(num1, num2)


result_sum = calc_sum.sum()
result_sub = calc_sub.subtract()
result_mul = calc_mul.multiply()
result_div = calc_div.divide()

print(f'Sum of {num1} and {num2} is {result_sum}')
print(f'The deffirence of {num1} and {num2} is {result_sub}')
print(f'The product of {num1} and {num2} is {result_mul}')
print(f'The division of {num1} and {num2} is {result_div}')