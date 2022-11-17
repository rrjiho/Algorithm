N = int(input())

S = []
for i in range(1,N):
  S = map(int, str(i))
  if N == i + sum(S):
    print(i)
    break
    
else: print(0)
