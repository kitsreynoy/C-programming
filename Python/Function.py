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


def simple_chatbot():
    print("សួស្តី! ខ្ញុំជា Chatbot របស់អ្នក។ តើខ្ញុំអាចជួយអ្វីបាន?")
    print("អ្នកអាចវាយ 'ចេញ' ដើម្បីបញ្ចប់ការសន្ទនា។")

    while True:
        user_input = input("អ្នក: ").lower() # ទទួលយកការបញ្ចូលពីអ្នកប្រើប្រាស់ និងបំប្លែងទៅជាអក្សរតូច

        if user_input == 'ចេញ':
            print("Chatbot: លាហើយ! រីករាយបាននិយាយជាមួយអ្នក។")
            break

        elif "សួស្តី" in user_input or "ជំរាបសួរ" in user_input:
            print("Chatbot: សួស្តី! តើអ្នកសុខសប្បាយជាទេ?")

        elif "សុខសប្បាយ" in user_input:
            print("Chatbot: ល្អណាស់! តើអ្នកមានអ្វីចង់សួរខ្ញុំទេ?")

        elif "ឈ្មោះ" in user_input:
            print("Chatbot: ខ្ញុំគ្មានឈ្មោះទេ។ ខ្ញុំគ្រាន់តែជា Chatbot មួយដែលបង្កើតឡើងដើម្បីជួយអ្នក!")

        elif "អាយុ" in user_input:
            print("Chatbot: ខ្ញុំជាកម្មវិធីកុំព្យូទ័រ ដូច្នេះខ្ញុំគ្មានអាយុទេ។")

        elif "អរគុណ" in user_input:
            print("Chatbot: រីករាយណាស់ដែលបានជួយ។")

        elif "អាកាសធាតុ" in user_input:
            print("Chatbot: ខ្ញុំមិនអាចមើលឃើញព័ត៌មានអាកាសធាតុបច្ចុប្បន្នទេ។")

        elif "ជំនួយ" in user_input:
            print("Chatbot: ខ្ញុំអាចឆ្លើយសំណួរទូទៅមួយចំនួនដូចជា ឈ្មោះ អាយុ ឬសុខទុក្ខជាដើម។")

        else:
            print("Chatbot: ខ្ញុំមិនទាន់យល់សំណួររបស់អ្នកនៅឡើយទេ។ សូមសាកល្បងសួរម្តងទៀត។")

       # ដំណើរការ Chatbot
if __name__ == "__main__":
    simple_chatbot()