from app.roman_converter import RomanConverter

converter = RomanConverter()

def user_input(choice):
    match choice:
        case 1:
            print("Please enter the Roman Numeral you would like to convert to an Integer")
            roman_numeral = input()
            print(converter.roman_to_int(roman_numeral))
            
        case 2:
            print("Please enter the Integer you would like to convert to a Roman Numeral")
            integer = input()
            print(converter.int_to_roman(int(integer)))    
            
        case _:
            return print("Invalid Choice")
        
        

print("Would you like to convert a Roman Numeral to an Integer(1) or an Integer to a Roman Numeral(2)?")

input_choice = int(input())
user_input(input_choice)








