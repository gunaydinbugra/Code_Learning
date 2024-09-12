import math
class Challenges:
    

# 1. Convert radians into degrees
# Write a function in Python that accepts one numeric parameter. This parameter will be the measure of an angle in radians. The function should convert the radians into degrees and then return that value.    
    def convrad(a):
        result = a * (180 / math.pi)
        return result


# 2. Sort a list
# Create a function in Python that accepts two parameters. The first will be a list of numbers. The second parameter will be a string that can be one of the following values: asc, desc, and none.

# If the second parameter is “asc,” then the function should return a list with the numbers in ascending order. If it’s “desc,” then the list should be in descending order, and if it’s “none,” it should return the original list unaltered.
    def sort(a,b):
        if(b == "asc"):
            for i in range(len(a)):
                for j in range(0,len(a)-1):
                    if a[j] > a[j+1]:
                        a[j], a[j+1] = a[j+1], a[j]
            return a
        elif(b == "desc"):
            for i in range(len(a)):
                for j in range(0,len(a)-1):
                    if a[j] < a[j+1]:
                        a[j], a[j+1] = a[j+1], a[j]
            return a
        elif(b == "none"):
            return a
        else:
            return "Invalid parameters entered"
    

# 3. Convert a decimal number into binary
# Write a function in Python that accepts a decimal number and returns the equivalent binary number. To make this simple, the decimal number will always be less than 1,024, so the binary number returned will always be less than ten digits long.
    def convb(a):
        if(0 < a < 1025):
            result = [0]*10
            c = 0
            while(a != 0):
                result[c] = a % 2
                a = a - result[c]
                a = a/2
                c += 1
        else:
            return a  
        result.reverse()
        resulted = int(''.join(map(str, list(map(int,result)))))
        return resulted
        

# 4. Count the vowels in a string
# Create a function in Python that accepts a single word and returns the number of vowels in that word. In this function, only a, e, i, o, and u will be counted as vowels — not y.
    def cvowels(a):
        counter = 0
        for i in range(len(a)):
            if a[i] in {'a', 'e', 'i', 'o', 'u'}:
                counter += 1
        return counter


# 5. Hide the credit card number
# Write a function in Python that accepts a credit card number. It should return a string where all the characters are hidden with an asterisk except the last four. For example, if the function gets sent “4444444444444444”, then it should return “4444”.
    def hcredit(a):
        a = str(a)
        if(len(a) < 17):
            a = ('*' * (len(a) - 4)) + a[-4:] 
            return a
        else:
            return "Invalid parameters entered"
        
        
# 6. Are the Xs equal to the Os?
# Create a Python function that accepts a string. This function should count the number of Xs and the number of Os in the string. It should then return a boolean value of either True or False.

# If the count of Xs and Os are equal, then the function should return True. If the count isn’t the same, it should return False. If there are no Xs or Os in the string, it should also return True because 0 equals 0. The string can contain any type and number of characters.
    def xeqo(a):
        cx = 0
        co = 0
        for i in range(len(a)):
            if a[i] == "x" or a[i] == "X":
                cx += 1
            elif a[i] == "o" or a[i] == "O":
                co += 1
        if cx == co:
            return True
        else:
            return False
        
        
# 7. Create a calculator function
# Write a Python function that accepts three parameters. The first parameter is an integer. The second is one of the following mathematical operators: +, -, /, or . The third parameter will also be an integer.

# The function should perform a calculation and return the results. For example, if the function is passed 6 and 4, it should return 24.
    def calc(a, b, c):
        if b == "+":
            return a+c
        elif b == "-":
            return a-c 
        elif b == "*":
            return a*c
        elif b == "/":
            return a/c
        else:
            return "Invalid parameters entered"


# 8. Give me the discount
# Create a function in Python that accepts two parameters. The first should be the full price of an item as an integer. The second should be the discount percentage as an integer.

# The function should return the price of the item after the discount has been applied. For example, if the price is 100 and the discount is 20, the function should return 80.
    def disc(a,b):
        return a - (a * (b/100))
    
    
# 9. Just the numbers
# Write a function in Python that accepts a list of any length that contains a mix of non-negative integers and strings. The function should return a list with only the integers in the original list in the same order.
    def oin(a):
        return [b for b in a if isinstance(b, int) and b>= 0]
    
    
# 10. Repeat the characters
# Create a Python function that accepts a string. The function should return a string, with each character in the original string doubled. If you send the function “now” as a parameter, it should return “nnooww,” and if you send “123a!”, it should return “112233aa!!”.
    def repeat(a):
        for i in range(0, len(a)*2, 2):
            i*2
            a = a[:i] + a[i] + a[i:] 
        return a
                
        
        