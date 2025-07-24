## 🔐 SecureCrypt (24/07/2025)

**SecureCrypt** is a simple Windows Forms application written in C# that allows you to **encrypt and decrypt text** using a basic character shift (Caesar cipher) algorithm.

---

### 🛠 Features

- Encrypt any text by shifting characters forward.
- Decrypt any encrypted text by shifting characters backward.
- Customizable key for encryption/decryption.
- Visual progress bars for both operations.
- Reset button to clear all fields and progress.

---

### 🧠 How It Works

The program uses a **Caesar Cipher** encryption method:
- Each character in the input is shifted by a specified key value.
- Decryption reverses this by subtracting the key.

For example, with key = 2:
A → C
B → D
...


If no key is entered, a **default key of 2** is used.

---

### 🖼 Interface

- **Input Text to Encrypt / Decrypt**: TextBox for your original or encoded message.
- **Key Input**: Optional. Enter a number (short) to use as the key.
- **Encrypt/Decrypt Buttons**: Trigger the conversion with progress bars.
- **Reset Button**: Clears all inputs and results.

---

### 🧾 Requirements

- .NET 
- Visual Studio (recommended for development)

---

### 🚀 How to Run

1. Clone the repository and Go to SecureCrypt folder.

2. Open the solution file (.sln) in Visual Studio.

3. Press F5 or click Start to run the app.

### Notes 
- This app is not secure for real-world encryption; it's educational only.

- Caesar Cipher is a basic substitution cipher and easily breakable.

### Made by https://github.com/EsmaRuya