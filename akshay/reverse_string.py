import unittest

class StringUtils:
    def reverseString(self, string_to_reverse):
        reversed_string = ''
        for i in range(1, len(string_to_reverse) + 1, 1):
            reversed_string += string_to_reverse[-i]
        
        return reversed_string

class Test_StringUtils(unittest.TestCase):
    test_string = 'Akshay'
    
    def test_reverseString(self):
        strUtils = StringUtils()
        self.assertEqual('yahskA', strUtils.reverseString(self.test_string))

if __name__ == '__main__':
    unittest.main()