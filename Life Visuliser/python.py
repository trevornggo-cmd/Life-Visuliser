import json


file_path = r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\bin\Debug\text.txt"

#save 

def save():
    with open(file_path, "a") as f:
        lines = "testing2\n"
        f.write(lines)

        
    
