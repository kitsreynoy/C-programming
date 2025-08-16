 # Step 1: Define function to calculate average
def calculate_average(scores):
    total = 0
    # Step 2: Use loop to sum the scores
    for score in scores:
        total += score
    # Step 3: Calculate the average
    average = total / len(scores)
    return average

# Step 4: Define list of scores (Math, Function, C++, English, Physics)
my_scores = [50, 60, 70, 60, 90]

# Step 5: Call the function and display result
avg = calculate_average(my_scores)
print("Average score is:", avg)

