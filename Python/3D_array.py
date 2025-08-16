#create 3D array
array_3d = [
   [ [1,2], [3,4]],
   [[5,6], [7,8]],
    [[9, 10], [11, 12]]
]

#please use elements
print("element in layer 1, row 1, column 1:", array_3d[1][0][1])
print("Layer 1:", array_3d[0])


#បោះពុម្ភអារេទាំងមូល
print("3D array:")
for layer in array_3d:
    for row in layer:
        print(row)
    print("-----")
    
    
#add more new alyer
array_3d.append([[13, 14] , [15, 16]])
print("After add layer:")
for layer in array_3d:
    for row in layer:
        for row in layer:
            print(row)
        print("----")