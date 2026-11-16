import unittest

from calculator import add, total


class CalculatorTests(unittest.TestCase):
    def test_add_two_numbers(self):
        self.assertEqual(add(2, 3), 5)

    def test_total_of_a_list(self):
        self.assertEqual(total([1, 2, 3]), 6)

    def test_total_of_prices_is_seven(self):
        # Deliberately wrong. The Testing chapter uses this failure.
        self.assertEqual(total([1, 2, 3]), 7)


if __name__ == "__main__":
    unittest.main()
