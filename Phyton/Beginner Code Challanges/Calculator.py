# Write a function in Python that accepts one numeric parameter. This parameter will be the measure of an angle in radians. The function should convert the radians into degrees and then return that value.

import math
class Calculator:
    def add(a,b):
        result = a + b
        return result
    def sub(a,b):
        result = a - b
        return result
    def div(a,b):
        result = a / b
        return result
    def mult(a,b):
        result = a * b
        return result
    def convrad(a):
        result = a * (180 / math.pi)
        return result