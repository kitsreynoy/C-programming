import tkinter as tk

# Function បង្ហាញពាក្យនៅ console
def rc_robot(command):
    if command == "F":
        print("Robot go forward")
    elif command == "B":
        print("Robot go backward")
    elif command == "L":
        print("Robot turn left")
    elif command == "R":
        print("Robot turn right")
    elif command == "S":
        print("Robot stop")
    else:
        print("Unknown command")

# បង្កើតផ្ទាំង (Window)
window = tk.Tk()
window.title("RC Robot Controller")
window.geometry("300x250")

# បង្កើតប៊ូតុងជាផ្នែក function
def create_button(text, row, col):
    return tk.Button(window, text=text, width=10, height=2,
                     command=lambda: rc_robot(text)).grid(row=row, column=col, padx=10, pady=10)

# ប៊ូតុង Robot Command
create_button("F", 0, 1)  # Forward
create_button("L", 1, 0)  # Left
create_button("S", 1, 1)  # Stop
create_button("R", 1, 2)  # Right
create_button("B", 2, 1)  # Backward

# បង្ហាញផ្ទាំង GUI
window.mainloop()