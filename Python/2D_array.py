#create 2D array
array_2d = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

#ចូលប្រើធាតុ
print("Element in row 1 column 1:", array_2d[1][2]) 
print("row 0:", array_2d[0])


#បោះពុម្ភអារេទាំងមូល
print("2D Array:")
for row in array_2d:
    print(row)
    
    
    
#add more new row
array_2d.append([10, 11, 12])
print("After add more row:")
for row in array_2d:
    print(row)
    
    
    