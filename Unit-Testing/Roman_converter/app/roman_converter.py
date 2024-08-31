class RomanConverter:
    def __init__(self):
        self.roman_numeral_dictionary_map = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
        }
        
        self.int_to_roman_tupple_map = [
            (1000, 'M'),
            (900, 'CM'),
            (500, 'D'),
            (400, 'CD'),
            (100, 'C'),
            (90, 'XC'),
            (50, 'L'),
            (40, 'XL'),
            (10, 'X'),
            (9, 'IX'),
            (5, 'V'),
            (4, 'IV'),
            (1, 'I')
        ]
    
    def roman_to_int(self, roman):
        total = 0
        prev_value = 0
        for char in reversed(roman):
            if char not in self.roman_numeral_dictionary_map:
                return f'Invalid Roman Numeral {char}'
            value = self.roman_numeral_dictionary_map[char]
            if value < prev_value:
                total -= value
            else:
                total += value
            prev_value = value
        
        if self.int_to_roman(total) != roman:
            return f'Invalid Roman Numeral sequence {roman}'
        return total
    
    def int_to_roman(self, num):
        roman_numeral = ''
        for value, roman in self.int_to_roman_tupple_map:
            while num >= value:
                roman_numeral += roman
                num -= value
        return roman_numeral