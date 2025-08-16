def filter_adult_students(ages):
    adult_list = []
    for age in ages:
        if age > 20:
          adult_list.append(age)
    return adult_list

#input age of the students
student_ages = [16,21,18,23,17,19]

#call function 
adults = filter_adult_students(student_ages)
print("The student have the age more than 20 year old:",adults)


        