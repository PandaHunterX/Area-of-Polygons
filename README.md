# Area-of-Polygons

![gif](https://github.com/user-attachments/assets/b8069a80-9c9d-4b29-abfd-8a21c64e0c68)

## Description
This project is a Windows Forms application built using the .NET Framework. It allows users to calculate the area of various polygons such as triangles, rectangles, squares, parallelograms, rhombuses, trapezoids, kites, and pentagons. The application optimizes the use of classes for clean and maintainable code.

## Features
- User-friendly graphical interface.
- Support for area calculation of multiple polygon types.
- Input validation for numeric fields to ensure accurate calculations.
- Clear error messages for invalid or missing inputs.

## Usage

1. Select the polygon for which you want to calculate the area.
2. Enter the required dimensions (e.g., base and height for a triangle).
3. Click the **Calculate** button to get the result.
4. The calculated area will be displayed in the respective text box.

### Example: Calculating the Area of a Triangle
Here’s a code snippet for calculating the area of a triangle:
```csharp
private void btn_TriangleArea_Click(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(txt_TriangleBase.Text) || string.IsNullOrWhiteSpace(txt_TriangleHeight.Text))
    {
        MessageBox.Show("Please enter both the base and height values.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    try
    {
        double Base = Convert.ToDouble(txt_TriangleBase.Text);
        double Height = Convert.ToDouble(txt_TriangleHeight.Text);

        if (Base <= 0 || Height <= 0)
        {
            MessageBox.Show("Base and Height must be positive numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Polygon Triangle = new Triangle(Base, Height);
        double Area = Triangle.getArea();

        txt_TriangleArea.Text = Area.ToString();
    }
    catch (FormatException)
    {
        MessageBox.Show("Please enter valid numeric values for the base and height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

## Object-Oriented Design
### Base Class: `Polygon`
The `Polygon` class serves as a blueprint for all polygon types. It includes:
- **Properties:** Stores measurements like `Base`, `Height`, `Width`, etc.
- **Abstract Method:**
  ```csharp
  public abstract double getArea();
  ```
  This enforces a consistent way to calculate the area across all polygon types.

### Derived Class: `Rectangle`
This class extends `Polygon` and provides the specific behavior for rectangles.
#### Constructor
```csharp
public Rectangle(double width, double length)
{
    this.Width = width;
    this.Length = length;
}
```
#### Area Calculation
```csharp
public override double getArea()
{
    return Width * Length;
}
```
> Note: The project includes other derived classes for shapes like triangles and squares. The `Rectangle` class is shown here as an example.


## Why This Design?
- **Abstraction:** Defines a common interface for different polygons.
- **Encapsulation:** Keeps measurement properties secure.
- **Reusability:** Easily extendable for new polygon types.

## Error Handling
- Ensures input fields are not empty.
- Validates that dimensions are positive.
- Handles invalid numeric input.

# How To Install?

### Step 1: Download the Installer  
![Screenshot 2025-02-04 214303](https://github.com/user-attachments/assets/241ceaae-2064-45ab-a1ad-4acc54c1457c)
- Visit [Area of Polygons](https://github.com/PandaHunterX/Area-of-Polygons/releases/tag/WinForms-App).  
- Click **area-of-polygons-setup.exe** to download the installer.  

---

### Step 2: Run the Installer  
 ![Screenshot 2025-02-04 213043](https://github.com/user-attachments/assets/78d8622e-e102-4717-9a29-0e550efe3438)
- Open **area-of-polygons-setup.exe** from your Downloads folder.

---

### Step 3: Choose Installation Directory  
![Screenshot 2025-02-04 213155](https://github.com/user-attachments/assets/264e6b4c-5643-4f65-b238-ee388f46be10)
- Select your preferred installation directory or leave it as the default.  
- Click **Next** to proceed.  

---

### Step 4: Create a Desktop Shortcut  
 ![Screenshot 2025-02-04 213316](https://github.com/user-attachments/assets/09cb34b9-cf6e-46eb-adbb-d4e9f387c848)
- Ensure the **Create desktop shortcut** option is checked.  
- Click **Next** to continue.

---

### Step 5: Install the Application  
 ![Screenshot 2025-02-04 213340](https://github.com/user-attachments/assets/286596a1-56eb-4410-80c5-f89b958597b5)
- Click **Install** to begin the installation process.  

---

### Step 6: Launch the Application!  
![Screenshot 2025-02-04 213423](https://github.com/user-attachments/assets/d92fd0aa-a39c-49cd-8b25-332779fb88ea)
- Once the installation is complete, you’re ready to open the application **Area of Polygons**.  
- Launch the app and enjoy!  
