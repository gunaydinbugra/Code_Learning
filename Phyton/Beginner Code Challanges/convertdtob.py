# Write a function in Python that accepts a decimal number and returns the equivalent binary number. To make this simple, the decimal number will always be less than 1,024, so the binary number returned will always be less than ten digits long.

class convertdtob:
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
        