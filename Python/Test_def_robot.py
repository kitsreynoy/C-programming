def rc_robot(command):
    command = str(input("Enter a choice(F , B , R , S):"))
    if command == "F":
        print("robot forword") #F = Forword
    elif command == "B":
        print("robot back") #B = Backward
    elif command == "L":
        print("robot turn left") #L = Left
    elif command == "R":
        print("robot turn right") #R = right
    elif command == "S":
        print("robot stop") #S = stop
    else:
        print("Unknow command")
rc_robot("command")








