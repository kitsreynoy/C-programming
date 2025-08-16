# បញ្ជូលពិន្ទុជាតារាង list
scores = [50, 60, 70, 80, 90]

subjects = ["Math", "Function", "C/C++", "English", "Physic"]

# Function គណនាមធ្យម
def calculate_average(score_list):
    total = 0
    for score in score_list:
        total += score
    average = total / len(score_list)
    return average

# បង្ហាញពិន្ទុតាម Loop
print("Scores by subject:")
for i in range(len(subjects)):
    print(f"{subjects[i]}: {scores[i]}")

# គណនាមធ្យម
avg = calculate_average(scores)
print("\nAverage Score:", avg)