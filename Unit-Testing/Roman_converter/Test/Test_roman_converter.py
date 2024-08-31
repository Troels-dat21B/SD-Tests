from app.roman_converter import RomanConverter

#
#Positive Test Cases
#
def test_roman_to_int_base():
        
        converter = RomanConverter()
        assert converter.roman_to_int('I') == 1
        assert converter.roman_to_int('IV') == 4
        assert converter.roman_to_int('IX') == 9
        assert converter.roman_to_int('X') == 10
        assert converter.roman_to_int('XL') == 40
        assert converter.roman_to_int('L') == 50
        assert converter.roman_to_int('XC') == 90
        assert converter.roman_to_int('C') == 100
        assert converter.roman_to_int('CD') == 400
        assert converter.roman_to_int('D') == 500
        assert converter.roman_to_int('CM') == 900
        assert converter.roman_to_int('M') == 1000


def test_int_to_roman_base():
    
    converter = RomanConverter()
    assert converter.int_to_roman(1) == 'I'
    assert converter.int_to_roman(4) == 'IV'
    assert converter.int_to_roman(9) == 'IX'
    assert converter.int_to_roman(10) == 'X'
    assert converter.int_to_roman(40) == 'XL'
    assert converter.int_to_roman(50) == 'L'
    assert converter.int_to_roman(90) == 'XC'
    assert converter.int_to_roman(100) == 'C'
    assert converter.int_to_roman(400) == 'CD'
    assert converter.int_to_roman(500) == 'D'
    assert converter.int_to_roman(900) == 'CM'
    assert converter.int_to_roman(1000) == 'M'

def test_roman_to_int():
    
    converter = RomanConverter()
    assert converter.roman_to_int('MMXXIV') == 2024

#
#Negative Test Cases
#
def test_roman_to_int_invalid_roman_base():
    
        converter = RomanConverter()
        assert converter.roman_to_int('A') == 'Invalid Roman Numeral A'
        assert converter.roman_to_int('B') == 'Invalid Roman Numeral B'
        assert converter.roman_to_int('E') == 'Invalid Roman Numeral E'
        assert converter.roman_to_int('F') == 'Invalid Roman Numeral F'
        assert converter.roman_to_int('G') == 'Invalid Roman Numeral G'
        assert converter.roman_to_int('H') == 'Invalid Roman Numeral H'
        assert converter.roman_to_int('J') == 'Invalid Roman Numeral J'
        assert converter.roman_to_int('K') == 'Invalid Roman Numeral K'
        assert converter.roman_to_int('N') == 'Invalid Roman Numeral N'
        assert converter.roman_to_int('O') == 'Invalid Roman Numeral O'
        assert converter.roman_to_int('P') == 'Invalid Roman Numeral P'
        assert converter.roman_to_int('Q') == 'Invalid Roman Numeral Q'
        assert converter.roman_to_int('R') == 'Invalid Roman Numeral R'
        assert converter.roman_to_int('S') == 'Invalid Roman Numeral S'
        assert converter.roman_to_int('T') == 'Invalid Roman Numeral T'
        assert converter.roman_to_int('U') == 'Invalid Roman Numeral U'
        assert converter.roman_to_int('W') == 'Invalid Roman Numeral W'
        assert converter.roman_to_int('Y') == 'Invalid Roman Numeral Y'
        assert converter.roman_to_int('Z') == 'Invalid Roman Numeral Z'



def test_roman_to_int_invalid_roman_sequence():
        converter = RomanConverter()
        assert converter.roman_to_int('XXXIVCCD') == 'Invalid Roman Numeral sequence XXXIVCCD'
        assert converter.roman_to_int('IIII') == 'Invalid Roman Numeral sequence IIII'
        assert converter.roman_to_int('VV') == 'Invalid Roman Numeral sequence VV'
        assert converter.roman_to_int('XXXX') == 'Invalid Roman Numeral sequence XXXX'
        assert converter.roman_to_int('LL') == 'Invalid Roman Numeral sequence LL'
        assert converter.roman_to_int('DD') == 'Invalid Roman Numeral sequence DD'
        assert converter.roman_to_int('IM') == 'Invalid Roman Numeral sequence IM'
        assert converter.roman_to_int('ID') == 'Invalid Roman Numeral sequence ID'