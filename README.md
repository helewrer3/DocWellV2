<div align="left" style="position: relative;">
<img src="https://raw.githubusercontent.com/PKief/vscode-material-icon-theme/ec559a9f6bfd399b82bb44393651661b08aaf7ba/icons/folder-markdown-open.svg" align="right" width="30%" style="margin: -20px 0 0 20px;">
<h1>DOCWELLV2</h1>
<p align="left">
	<em><code>A nurse management app built using ASP.Net</code></em>
</p>
<p align="left">
	<img src="https://img.shields.io/github/license/helewrer3/DocWellV2?style=flat-square&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/helewrer3/DocWellV2?style=flat-square&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/helewrer3/DocWellV2?style=flat-square&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/helewrer3/DocWellV2?style=flat-square&color=0080ff" alt="repo-language-count">
</p>
<p align="left">Built with the tools and technologies:</p>
<p align="left">
	<img src="https://img.shields.io/badge/NuGet-004880.svg?style=flat-square&logo=NuGet&logoColor=white" alt="NuGet">
	<img src="https://img.shields.io/badge/PostgreSQL-004880.svg?style=flat-square&logo=Postgresql&logoColor=white" alt="PostgreSQL">
	<img src="https://img.shields.io/badge/Blazor-004880.svg?style=flat-square&logo=blazor&logoColor=white" alt="Blazor">
	<img src="https://img.shields.io/badge/.NET-004880.svg?style=flat-square&logo=.net&logoColor=white" alt=".NET">
	<img src="https://img.shields.io/badge/.NET-004880.svg?style=flat-square&logo=.net&logoColor=white" alt=".NET">
</p>
</div>
<br clear="right">

## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📁 Project Structure](#-project-structure)
    - [📂 Project Index](#-project-index)
- [🚀 Getting Started](#-getting-started)
    - [☑️ Prerequisites](#-prerequisites)
    - [⚙️ Installation](#-installation)
    - [🤖 Usage](#🤖-usage)
    - [🧪 Testing](#🧪-testing)

---

## 📍 Overview

<code>V2 of my previous attempt at [this](https://github.com/helewrer3/Docwell)</code>

---

## 👾 Features


- **Authentication**:  
  Custom implemented minimal authentication that gets the job done.

- **Patient Records Management**:  
  Create, filter, and view records of patients and their respective visits.

- **Prescription and Report Upload**:  
  Safely upload all relevant prescriptions and reports associated with a particular visit to the cloud.

---

## 📁 Project Structure

```sh
└── DocWellV2/
    ├── Components
    │   ├── App.razor
    │   ├── Layout
    │   ├── Pages
    │   ├── Routes.razor
    │   └── _Imports.razor
    ├── Data
    │   ├── AppDbContext.cs
    │   └── Models
    ├── DocWellV2.csproj
    ├── DocWellV2.sln
    ├── Migrations
    │   ├── 20241229185423_Added Patients.Designer.cs
    │   ├── 20241229185423_Added Patients.cs
    │   ├── 20241229192305_Added Visits, Prescriptions.Designer.cs
    │   ├── 20241229192305_Added Visits, Prescriptions.cs
    │   ├── 20241229192417_Added attrib in Prescription.Designer.cs
    │   ├── 20241229192417_Added attrib in Prescription.cs
    │   ├── 20250102115510_Update Patient Constraint.Designer.cs
    │   ├── 20250102115510_Update Patient Constraint.cs
    │   ├── 20250102122622_Update Patient age, weight to float.Designer.cs
    │   ├── 20250102122622_Update Patient age, weight to float.cs
    │   ├── 20250104064226_Update visit and prescirption non-nullable values.Designer.cs
    │   ├── 20250104064226_Update visit and prescirption non-nullable values.cs
    │   └── AppDbContextModelSnapshot.cs
    ├── Program.cs
    ├── Properties
    │   └── launchSettings.json
    ├── Services
    │   ├── PatientService.cs
    │   ├── PrescriptionService.cs
    │   └── VisitService.cs
    ├── Utils
    │   ├── Medicine.cs
    │   ├── NewVisit.cs
    │   └── SecretManager.cs
    ├── appsettings.Development.json
    └── wwwroot
        ├── app.css
        ├── favicon.png
        └── lib
```


### 📂 Project Index
<details open>
	<summary><b><code>DOCWELLV2/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/appsettings.Development.json'>appsettings.Development.json</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/DocWellV2.sln'>DocWellV2.sln</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Program.cs'>Program.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/DocWellV2.csproj'>DocWellV2.csproj</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Utils Submodule -->
		<summary><b>Utils</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Utils/NewVisit.cs'>NewVisit.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Utils/SecretManager.cs'>SecretManager.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Utils/Medicine.cs'>Medicine.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Components Submodule -->
		<summary><b>Components</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Routes.razor'>Routes.razor</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/_Imports.razor'>_Imports.razor</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/App.razor'>App.razor</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
			<details>
				<summary><b>Pages</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/ViewVisits.razor'>ViewVisits.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/AddVisit.razor'>AddVisit.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/ViewPatients.razor'>ViewPatients.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/Home.razor'>Home.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/EditPatient.razor'>EditPatient.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Pages/AddPatient.razor'>AddPatient.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
			<details>
				<summary><b>Layout</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Layout/MainLayout.razor.css'>MainLayout.razor.css</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Layout/NavMenu.razor'>NavMenu.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Layout/NavMenu.razor.css'>NavMenu.razor.css</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Components/Layout/MainLayout.razor'>MainLayout.razor</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- Migrations Submodule -->
		<summary><b>Migrations</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229185423_Added Patients.Designer.cs'>20241229185423_Added Patients.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/AppDbContextModelSnapshot.cs'>AppDbContextModelSnapshot.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229192305_Added Visits, Prescriptions.Designer.cs'>20241229192305_Added Visits, Prescriptions.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229192417_Added attrib in Prescription.cs'>20241229192417_Added attrib in Prescription.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250102115510_Update Patient Constraint.cs'>20250102115510_Update Patient Constraint.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250104064226_Update visit and prescirption non-nullable values.cs'>20250104064226_Update visit and prescirption non-nullable values.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229192417_Added attrib in Prescription.Designer.cs'>20241229192417_Added attrib in Prescription.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250104064226_Update visit and prescirption non-nullable values.Designer.cs'>20250104064226_Update visit and prescirption non-nullable values.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229192305_Added Visits, Prescriptions.cs'>20241229192305_Added Visits, Prescriptions.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250102115510_Update Patient Constraint.Designer.cs'>20250102115510_Update Patient Constraint.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250102122622_Update Patient age, weight to float.Designer.cs'>20250102122622_Update Patient age, weight to float.Designer.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20241229185423_Added Patients.cs'>20241229185423_Added Patients.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Migrations/20250102122622_Update Patient age, weight to float.cs'>20250102122622_Update Patient age, weight to float.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Services Submodule -->
		<summary><b>Services</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Services/VisitService.cs'>VisitService.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Services/PatientService.cs'>PatientService.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Services/PrescriptionService.cs'>PrescriptionService.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Properties Submodule -->
		<summary><b>Properties</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Properties/launchSettings.json'>launchSettings.json</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Data Submodule -->
		<summary><b>Data</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Data/AppDbContext.cs'>AppDbContext.cs</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
			<details>
				<summary><b>Models</b></summary>
				<blockquote>
					<table>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Data/Models/Prescription.cs'>Prescription.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Data/Models/Visit.cs'>Visit.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					<tr>
						<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/Data/Models/Patient.cs'>Patient.cs</a></b></td>
						<td><code>❯ REPLACE-ME</code></td>
					</tr>
					</table>
				</blockquote>
			</details>
		</blockquote>
	</details>
	<details> <!-- wwwroot Submodule -->
		<summary><b>wwwroot</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/helewrer3/DocWellV2/blob/master/wwwroot/app.css'>app.css</a></b></td>
				<td><code>❯ REPLACE-ME</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
</details>

---
## 🚀 Getting Started

### ☑️ Prerequisites

Before getting started with DocWellV2, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget


### ⚙️ Installation

Install DocWellV2 using one of the following methods:

**Build from source:**

1. Clone the DocWellV2 repository:
```sh
❯ git clone https://github.com/helewrer3/DocWellV2
```

2. Navigate to the project directory:
```sh
❯ cd DocWellV2
```

3. Install the project dependencies:


**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```




### 🤖 Usage
Run DocWellV2 using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```


### 🧪 Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet test
```