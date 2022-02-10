import unittest
import demo


class TestAdder1(unittest.TestCase):
    def test_positive_values(self):
        # Given
        num1 = 3
        num2 = 7
        expected_answer = 10

        # When
        actual_answer = demo.adder_1(num1, num2)

        # Then
        self.assertEqual(actual_answer, expected_answer)

    def test_negative_values(self):
        # Given
        num1 = -3
        num2 = -7
        expected_answer = -10

        # When
        actual_answer = demo.adder_1(num1, num2)

        # Then
        self.assertEqual(actual_answer, expected_answer)


# Test Adder 2 below


if __name__ == '__main__':
    unittest.main()
