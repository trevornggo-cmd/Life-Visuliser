import json
import os 


#creating both files

   try:
        os.makedirs(r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data", exist_ok=True)
        file_path = os.path.join(r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data", FileA)

      
        with open(FileA, 'w') as fa:
            fa.write(placeholder) 

        print(f"File created successfully at: {file_path}")

    except OSError as e:
        print(f"Error creating file: {e}")
    except Exception as e:
        print(f"Unexpected error: {e}")


   try:
        os.makedirs(r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data", exist_ok=True)
        file_path = os.path.join(r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data", FileB)

      
        with open(FileB, 'w') as fa:
            fa.write(placeholder) 

        print(f"File created successfully at: {file_path}")

    except OSError as e:
        print(f"Error creating file: {e}")
    except Exception as e:
        print(f"Unexpected error: {e}")

#splitting both files into different paths

file_pathOUT = r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data\FileA.txt"
file_pathIN = r"C:\Users\trevo\OneDrive\Documents\C# thing\a new personal winform folder\Life Visuliser\Life Visuliser\data\FileB.txt"

#save 

def save():
    with open(file_path, "a") as f:
        lines = "testing2\n"
        f.write(lines)

        
    
