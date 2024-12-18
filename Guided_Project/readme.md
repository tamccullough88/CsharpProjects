# Contoso Pets Application

You're working on the **Contoso Pets** application, an app that helps place pets in new homes. Below are the specifications for your application:

---

## Application Specifications

### 1. Application Setup
- **Create a C# console application.**
- **Store application data** in a multidimensional string array named `ourAnimals`.

### 2. Data Structure: `ourAnimals`
The `ourAnimals` array includes the following "pet characteristics" for each animal:
- **Pet ID #**
- **Pet species** (cat or dog)
- **Pet age** (years)
- **Physical description** (condition/characteristics)
- **Personality description**
- **Pet nickname**

### 3. Sample Dataset
- Implement a **sample dataset** representing dogs and cats currently in care.

---

## Main Features

### 1. Menu Options
Display menu options to access the application's main features.

### 2. Core Tasks
The main features enable the following tasks:
1. **List pet information** for all animals in the `ourAnimals` array.
2. **Add new animals** to the `ourAnimals` array:
   - Pet species (dog or cat) must be entered.
   - Pet ID must be programmatically generated.
   - Physical characteristics like age, breed, and spay/neuter status may be unknown until a vet examination.
   - Nickname and personality may be unknown upon arrival.
3. **Ensure completeness** of:
   - Animal ages and physical descriptions (after vet exams).
   - Nicknames and personality descriptions (after team observation).
4. **Edit animal data:**
   - Update an animal’s **age** (e.g., after a known birthday).
   - Update an animal’s **personality description** (e.g., based on time in care).
5. **Filter animals** based on user-specified characteristics:
   - Display all cats meeting specified physical characteristics.
   - Display all dogs meeting specified physical characteristics.

---

## Starter Code Overview

The **Starter Code Project** includes a `Program.cs` file that provides the following:

### 1. Variable Declarations
- Variables for collecting and processing pet data and menu selections.

### 2. `ourAnimals` Array
- Declared and initialized with a sample dataset using a `for` loop and `if-elseif-else` construct.

### 3. Main Menu Options
The code displays these main menu options:
- **List all current pet information.**
- **Assign values to `ourAnimals` array fields.**
- **Ensure completeness** of animal ages and physical descriptions.
- **Ensure completeness** of nicknames and personality descriptions.
- **Edit an animal's age.**
- **Edit an animal's personality description.**
- **Display all cats** with a specified characteristic.
- **Display all dogs** with a specified characteristic.

### 4. User Interaction
- Users enter a menu selection or type `"Exit"` to exit.
- User selections are echoed back with a message.

---

## Development Goals

Your goal is to develop features for the first two menu options:

### 1. Update Sample Data
- Modify the code to create the application's sample dataset.

### 2. Main Menu
- Build a **loop** around the main menu.
- Create a **selection statement** that establishes a code branch for each menu option.

### 3. Menu Option 1: Display All Data
- Write code to display all data in the `ourAnimals` array.

### 4. Menu Option 2: Add New Animals
- Build a **loop** for entering new data into the `ourAnimals` array (Part 1).
- Write code to read and save the new data (Part 2).

### 5. Testing
- Test the application at each stage of development.

---

## Setup Instructions

### 1. Download the Starter Project
1. [Download the Starter Project code](#) as a zip file.
2. **Unzip the files** in your development environment:
   - Use your PC for local development or a hosted environment.
   - Navigate to your downloads folder.
   - Right-click `Guided-project-branching-looping-CSharp-main.zip` and select **Extract All**.
   - Select **Show extracted files when complete** and then select **Extract**.
   - Note the extracted folder location.
   - Copy the `GuidedProject` folder to your Windows Desktop.

   **Note:** If a `GuidedProject` folder already exists, select **Replace the files in the destination**.

### 2. Open in Visual Studio Code
1. Open **Visual Studio Code** locally or in a sandbox.
2. Navigate to the `GuidedProject` folder:
   - On the **File** menu, select **Open Folder**.
   - Locate the `GuidedProject` folder on your desktop.
   - Select the folder and click **Open**.

3. Verify the folder structure in **EXPLORER**:
   - The folder should contain two subfolders: `Final` and `Starter`.

---

## Next Steps
You're now ready to begin the Guided Project exercises. Good luck!