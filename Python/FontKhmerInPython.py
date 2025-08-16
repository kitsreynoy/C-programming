import tkinter as tk

# Create the main window
window = tk.Tk()
window.title("សូមស្វាគមន៍")  # Window title
window.geometry("300x150")    # Width x Height

# Create a label with Khmer greeting
label = tk.Label(window, text="សួស្តីថ្នាក់ M1", font=("Khmer OS", 18), fg="blue")
label.pack(expand=True)

# Run the GUI loop
window.mainloop()