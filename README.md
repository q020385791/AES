# AES 加密/解密工具 (AES Encryption/Decryption Tool)

## 簡介 (Introduction)

此專案提供一個簡單的 Windows Forms 應用程式，能夠使用 AES (Advanced Encryption Standard) 技術進行字串的加密與解密。加密模式採用 CBC (Cipher Block Chaining) 模式，並使用 Base64 編碼處理密文輸出，以便於安全地在網路上傳輸。

This project provides a simple Windows Forms application capable of performing string encryption and decryption using AES (Advanced Encryption Standard). The encryption mode used is CBC (Cipher Block Chaining), and Base64 encoding is applied to the ciphertext for secure transmission over networks.

## 功能 (Features)

- 使用 AES 加密和解密字串。
- 支援 Base64 編碼與 URL 友好的字元轉換。
- 使用 CBC 模式提高安全性。
- 自動生成和嵌入初始向量 (IV) 到密文中。


- Encrypt and decrypt strings using AES.
- Support for Base64 encoding with URL-friendly character replacement.
- Enhanced security with CBC mode.
- Automatic generation and embedding of the Initialization Vector (IV) in the ciphertext.

## 環境需求 (Requirements)

- .NET Framework 4.7.2 或更新版本
- Visual Studio 2019 或更新版本


- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later

## 安裝與使用 (Installation and Usage)

1. 克隆或下載此存儲庫到本地機器。
2. 打開 `AES.sln` 解決方案檔案。
3. 編譯並運行專案。
4. 輸入需要加密或解密的字串，然後點擊「加密」或「解密」按鈕查看結果。


1. Clone or download this repository to your local machine.
2. Open the `AES.sln` solution file.
3. Build and run the project.
4. Enter the string you wish to encrypt or decrypt, and click the "Encrypt" or "Decrypt" button to see the result.

## 專案結構 (Project Structure)

- **WanLib**: 包含 AES 加密與解密邏輯的靜態類別庫。
- **AES**: Windows Forms 應用程式，用於用戶交互。


- **WanLib**: Contains the static class library for AES encryption and decryption logic.
- **AES**: Windows Forms application for user interaction.

## 使用方式 (How to Use)

### 加密 (Encryption)
輸入欲加密的字串並點擊「加密」按鈕，密文將顯示在 `txtEncryptR` 文本框中。

Enter the string to be encrypted and click the "Encrypt" button. The encrypted text will be displayed in the `txtEncryptR` text box.

### 解密 (Decryption)
輸入欲解密的 Base64 編碼字串並點擊「解密」按鈕，原文將顯示在 `txtDecryptR` 文本框中。

Enter the Base64 encoded string to be decrypted and click the "Decrypt" button. The decrypted text will be displayed in the `txtDecryptR` text box.

## 程式碼簡介 (Code Overview)

### WanLib.AES 類 (Class)

```csharp
public static class AES
{
    private static readonly string key = "Here is your key";

    public static string AESEncrypt(string input) { ... }

    public static string AESDecrypt(string input) { ... }
}
