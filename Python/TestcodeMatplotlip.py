import matplotlib.pyplot as plt

# បញ្ជាក់ឈ្មោះ Font
plt.rcParams['font.family'] = 'Noto Sans Khmer'

tests = ["តេស្ត 1", "តេស្ត 2", "តេស្ត 3", "តេស្ត 4", "តេស្ត 5"]
scores = [65, 72, 68, 85, 90]

plt.figure(figsize=(8, 5))
plt.plot(range(1, len(scores) + 1), scores, marker='o')

plt.title("ក្រាហ្វបន្ទាត់ បង្ហាញពិន្ទុ")
plt.xlabel("តេស្ត")
plt.ylabel("ពិន្ទុ")
plt.ylim(0, 100)
plt.xticks(range(1, len(tests) + 1), tests)
plt.grid(True)

for i, v in enumerate(scores, start=1):
    plt.text(i, v + 2, str(v), ha='center', va='bottom')

plt.show()