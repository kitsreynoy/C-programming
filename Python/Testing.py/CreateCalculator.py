x=float(input("Enter x: "))
y=float(input("Enter y: "))
#Please input operation that you want to calculator.(+,-,*,/)
operation = input("Please chosean operator(+,-,*,/):  ")
# use if-elif-else ដើម្បីគណនាប្រមាណវិធី
if operation == "+":
    print(f"x + y = {x + y}")
elif operation == "-":
    print(f"x - y = {x - y}")
elif operation == "*":
    print(f"x * y = {x * y}")
elif operation == "/":
    if y != 0:
        print(f"x / y = {x / y}")
    else:
        print("មិនអាចបែងចែកដោយ ០ បានទេ")
else: 
        print("ប្រមាណវិធីមិនត្រឹមត្រូវ!")