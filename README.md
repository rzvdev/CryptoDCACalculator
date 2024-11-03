# <h1 align="center">CryptoDCACalculator</h1>

<p align="center">
  <b>CryptoDCACalculator</b> is a web application designed for calculating and tracking Dollar-Cost Averaging (DCA) investments in various cryptocurrencies.
</p>
<p align="center">
  Built with <b>C#</b>, <b>.NET Core API</b>, <b>Blazor</b>, and <b>SQL</b>, this app integrates with the <b>CoinMarketCap API</b> to provide real-time data, making it easy to visualize and manage cryptocurrency investments.
</p>

---

## 🌟 Features

- **DCA Calculations**: Calculate and analyze Dollar-Cost Averaging returns on different cryptocurrencies.
- **Current Investments Table**: View and manage current investments, including live prices.
- **Investment History Table**: Access a detailed log of all past investments.
- **Investment Summary Chart**: Visualize which cryptocurrencies have the highest investment volume and distribution.
- **Real-Time Data Integration**: Fetches live data from the CoinMarketCap API for accurate, up-to-date calculations.

---

## 🛠️ Technologies

<table>
  <tr>
    <td><b>Backend</b></td>
    <td>.NET Core API</td>
  </tr>
  <tr>
    <td><b>Frontend</b></td>
    <td>Blazor</td>
  </tr>
  <tr>
    <td><b>Database</b></td>
    <td>SQL</td>
  </tr>
  <tr>
    <td><b>Third-Party API</b></td>
    <td>CoinMarketCap API</td>
  </tr>
</table>

---

## 🚀 Getting Started

### Prerequisites

1. [.NET Core SDK](https://dotnet.microsoft.com/download)
2. [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
3. [CoinMarketCap API Key](https://pro.coinmarketcap.com/signup/)

### Installation

<ol>
  <li><b>Clone the Repository</b></li>
  <li><b>Configure the Database</b></li> 
  <p>Set up an SQL Server database and update the connection string in <code>appsettings.json</code>. <br> Publish the Database project from visual studio.</p>
  <li><b>Set up CoinMarketCap API Key</b></li> 
  <p>Add your CoinMarketCap API Key to the environment or directly in the configuration file. <br> Or you can omit this step because have already their testing API key</p>
  <li><b>Build and Run</b></li>
</ol>
  


📂 Project Structure
<table> <tr> <td><b>CryptoDCA.APP</b></td> <td>Contains the Blazor application and front-end components for UI and user interaction.</td> </tr> <tr> <td><b>CryptoDCA.DataAccess</b></td> <td>Handles data access and communicates with the database.</td> </tr> <tr> <td><b>CryptoDCA.DataModel</b></td> <td>Defines the data models and entities used in the application.</td> </tr> <tr> <td><b>CryptoDCA.Database</b></td> <td>Manages database setup, migrations, and schemas.</td> </tr> <tr> <td><b>CryptoDCA.DomainLogic</b></td> <td>Contains core application logic, including DCA calculations and business rules.</td> </tr> <tr> <td><b>CryptoDCA.Integration</b></td> <td>Manages external API integrations, specifically with CoinMarketCap for live crypto data.</td> </tr> </table>

<br>
📸 Screenshots

https://github.com/user-attachments/assets/7e5371db-109f-4a6f-b188-dd23a8e1b8e0




🤝 Contributing
<ol> <li>Fork the project.</li> <li>Create a new branch (<code>git checkout -b feature/AmazingFeature</code>).</li> <li>Commit your changes (<code>git commit -m 'Add some AmazingFeature'</code>).</li> <li>Push to the branch (<code>git push origin feature/AmazingFeature</code>).</li> <li>Open a Pull Request.</li> </ol>


💬 Contact
<p>Lungu Răzvan</p> <p> <a href="https://linkedin.com/in/lungurazvan">LinkedIn</a> | <a href="mailto:lungurazvandev@outlook.com">Email</a> </p>
<p align="center"><b>Happy calculating! 📈🚀</b></p> 
