# Online Tradding System

A comprehensive Windows Forms application for managing jewelry sales, gold investments, and user accounts. Built with C# and SQL Server, this system provides both customer and administrative interfaces for a complete jewelry store experience.

## 🌟 Features

### Customer Features
- **Product Catalog**: Browse diamonds, gold, and silver jewelry with different karat options
- **Shopping Cart**: Add items to cart with quantity and karat selection
- **Payment Processing**: Multiple payment methods (Bkash, Nagad, Cash on Delivery)
- **Gold Investment**: Buy and sell gold with real-time pricing
- **User Profiles**: Manage personal information and profile pictures
- **User Authentication**: Secure login and registration system

### Admin Features
- **Investment Management**: View and manage all user investments
- **Price Control**: Set and update gold gram prices
- **User Search**: Search investments by username
- **Dashboard Analytics**: Monitor system activity

## 🛠️ Technology Stack

- **Frontend**: Windows Forms (.NET Framework)
- **Backend**: C# with ADO.NET
- **Database**: Microsoft SQL Server
- **Architecture**: 3-Layer Architecture (Presentation, Business Logic, Data Access)

## 📋 Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- SQL Server 2016 or later (Express edition supported)
- Windows 10 or later

## 🚀 Installation

### 1. Clone the Repository
```bashs
git clone https://github.com/mrxvaau/Vault2DoorFrom.git
cd Vault2DoorFrom
```

### 2. Database Setup

#### Create Database
Execute the following SQL commands to create the required database and tables:

```sql
CREATE DATABASE investment;
USE investment;

-- Users table
CREATE TABLE tblUser (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255),
    Mobile NVARCHAR(20),
    CreatedDate DATETIME DEFAULT GETDATE(),
    UpdatedDate DATETIME
);

-- User profiles table
CREATE TABLE tblUserProfile (
    ProfileID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES tblUser(UserID),
    Username NVARCHAR(50),
    ProfilePicture NVARCHAR(255),
    Email NVARCHAR(100),
    Address NVARCHAR(255),
    Mobile NVARCHAR(20)
);

-- Products purchase table
CREATE TABLE ProductsBuy (
    PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES tblUser(UserID),
    Username NVARCHAR(50),
    ProductName NVARCHAR(100),
    Karat INT,
    Price DECIMAL(10,2),
    Quantity INT,
    PaymentMethod NVARCHAR(50),
    PurchaseDate DATETIME DEFAULT GETDATE()
);

-- Investment details table
CREATE TABLE InvestmentDetails (
    InvestmentID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES tblUser(UserID),
    Username NVARCHAR(50),
    QuantityBought DECIMAL(10,2),
    TotalSpent DECIMAL(10,2),
    GramPriceAtBuy DECIMAL(10,2),
    QuantitySold DECIMAL(10,2) DEFAULT 0,
    TotalReceived DECIMAL(10,2) DEFAULT 0,
    Profit DECIMAL(10,2) DEFAULT 0,
    BuyDate DATETIME DEFAULT GETDATE(),
    SellDate DATETIME
);

-- Configuration table for gold prices
CREATE TABLE Config (
    ConfigKey NVARCHAR(50) PRIMARY KEY,
    ConfigValue NVARCHAR(255)
);

-- Insert default gold price
INSERT INTO Config (ConfigKey, ConfigValue) VALUES ('GramPrice', '50.00');
```

### 3. Connection String Configuration

Update the connection string in `App.config`:

```xml
<connectionStrings>
  <add name="StoreShop" 
       connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=investment;Integrated Security=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g., `localhost\SQLEXPRESS`).

### 4. Profile Images Setup

Create an `Images` folder in your project directory for storing user profile pictures:
```
Store/
├── Images/
│   └── default.png
└── ...
```

### 5. Build and Run

1. Open `Store.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Set `Store` as startup project
4. Run the application (F5)

## 📖 Usage Guide

### First Time Setup

1. **Admin Account**: Create an admin account during registration
2. **Set Gold Price**: Login as admin and set the current gold price
3. **Customer Registration**: Users can register and start shopping

### Customer Workflow

1. **Register/Login**: Create account or login
2. **Browse Products**: Navigate through Diamond, Gold, and Silver sections
3. **Select Products**: Choose karat and quantity
4. **Add to Cart**: Review items before checkout
5. **Payment**: Select payment method and complete purchase
6. **Gold Investment**: Buy/sell gold for investment purposes

### Admin Workflow

1. **Login**: Use admin credentials
2. **Set Prices**: Update gold prices in real-time
3. **Monitor Investments**: View all user investments
4. **Search Users**: Filter investments by username

## 🏗️ Project Structure

```
Store/
├── DataQ/
│   └── DatabaseQ.cs          # Data access layer
├── Forms/
│   ├── LoginForm.cs          # User authentication
│   ├── RegistrationForm.cs   # New user registration
│   ├── AdminDashboard.cs     # Admin panel
│   ├── ChoiceSection.cs      # Main navigation
│   ├── *Variants.cs          # Product category pages
│   ├── CartForm.cs           # Shopping cart
│   ├── PaymentForm.cs        # Payment processing
│   ├── InvestmentSection.cs  # Gold investment
│   ├── MyUserProfile.cs      # User profile management
│   └── SellGold.cs           # Gold selling interface
├── Models/
│   ├── User.cs               # User entity
│   ├── UserProfile.cs        # User profile entity
│   └── CartItem.cs           # Shopping cart item
├── Properties/
├── App.config                # Configuration file
└── Program.cs                # Application entry point
```

## 🔧 Configuration

### Database Configuration
- Update connection strings in `App.config`
- Ensure SQL Server is running and accessible

### Image Storage
- Profile pictures stored in `/Images/` directory
- Supports JPG, JPEG, PNG formats
- Default profile image: `default.png`

## 🛡️ Security Features

- **Password Protection**: Secure user authentication
- **Role-Based Access**: Separate admin and user interfaces
- **SQL Injection Prevention**: Parameterized queries
- **Data Validation**: Input validation on all forms

## 🐛 Troubleshooting

### Common Issues

**Database Connection Failed**
- Verify SQL Server is running
- Check connection string in App.config
- Ensure database exists and tables are created

**Profile Image Not Loading**
- Check if Images folder exists
- Verify default.png is present
- Ensure proper file permissions

**Login Issues**
- Verify username and password
- Check if user exists in database
- Ensure database connection is working

## 📝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Authors

- **Your Name** - *Initial work* - [mrxvaau](https://github.com/mrxvaau)

## 🙏 Acknowledgments

- Thanks to the .NET community for excellent documentation
- SQL Server team for robust database platform
- Windows Forms team for UI framework

## 📞 Support

For support, email mrxavu@gmail.com or create an issue in the GitHub repository.

## 🔄 Version History

- **v1.0.0** - Initial release
  - User authentication system
  - Product catalog with multiple categories
  - Shopping cart and payment processing
  - Gold investment functionality
  - Admin dashboard
  - User profile management

---

Made with ❤️ for jewelry store management
