# Create a function in Python that accepts two parameters. The first will be a list of numbers. The second parameter will be a string that can be one of the following values: asc, desc, and none.

# If the second parameter is “asc,” then the function should return a list with the numbers in ascending order. If it’s “desc,” then the list should be in descending order, and if it’s “none,” it should return the original list unaltered.

class sortalist:
    def sort(a,b):
        if(b == "asc"):
            for i in range(len(a)):
                for j in range(0,len(a)-1):
                    if a[j] < a[j+1]:
                        a[j], a[j+1] = a[j+1], a[j]
            return a
        elif(b == "desc"):
            for i in range(len(a)):
                for j in range(0,len(a)-1):
                    if a[j] > a[j+1]:
                        a[j], a[j+1] = a[j+1], a[j]
            return a
        elif(b == "none"):
            return a
        else:
            print("Invalid parameters entered")