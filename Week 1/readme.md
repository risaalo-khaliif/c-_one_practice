# C# Variables, String Concatenation & Data Parsing Practice

## Overview

This practice demonstrates how to:

* Create `string` and `int` variables in C#
* Retrieve inputs from Windows Forms `TextBox` controls
* Parse text input into integer values using `int.Parse()`
* Concatenate multiple variables into a single combined string
* Display combined output using a `Label` control
* Reset and clear `TextBox` and `Label` controls

---

## 1. Creating Variables

In this step, different variable types are declared to store student information and date details.

* Student Data Variables: `student_name`, `student_id`, `department`, `semester`, and `fulldata` are declared as `string` types.


* Date Information Variables: `dayof_Week`, `name_of_month`, and `fulldata` are declared as `string` types, while `numeric_day` and `year` are declared as `int` types.



The following screenshots show how the variables are declared in C#.

---

## 2. Assigning Values and Parsing Data

Values are assigned to variables directly from `TextBox` controls[cite: 1, 3]. For integer types, string input from the form is converted using `int.Parse()`[cite: 3].

* **Student Data Assignment:** Controls like `txtname.Text`, `txtstudentid.Text`, `txtdepartment.Text`, and `txtsemester.Text` are directly stored into their corresponding string variables.


* **Date Data Parsing:** Text inputs from `txtof_month.Text` and `txtYEAR.Text` are parsed into integer variables `numeric_day` and `year` using `int.Parse()`[cite: 3].

The following screenshots show the assignment and parsing code.


[cite: 3]

---

## 3. Concatenating and Displaying Data

In this step, the values from multiple variables are combined into a single string using the `+` operator with spaces `" "` added between each item to format the output correctly[cite: 1, 4].

* **Student Information:** Combined into `fulldata` and assigned to `lbloutput.Text`.


* **Date Information:** Combined using `dayof_Week`, `name_of_month`, `numeric_day`, and `year`, then output to `lpoutput.Text`[cite: 4].

The following screenshot shows the string concatenation process.

[cite: 4]

---

## 4. Clearing Controls

To reset the user interface, `TextBox` inputs are cleared using the `.Clear()` method, and the output `Label` text is reset to an empty string[cite: 5, 6].

* `.Clear()` is called on controls like `txtname`, `txtstudentid`, `txtDayoftheweek`, and `txtYEAR`[cite: 5, 6].
* Output labels (`lbloutput` / `lpoutput`) are cleared by assigning an empty string (`" "`) to their `.Text` property[cite: 5, 6].

The following screenshots show the control clearing routines.

[cite: 5]
[cite: 6]