a=int (input("Enter numbers a: "))
b=int(input("Enter number b:"))
while (a!=b):
    if(a>b):
        max=a
    else:
        max=b
    print("Max is:",max)
    break
