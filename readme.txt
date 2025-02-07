Question 2:
To insert PEP in my system, I create a new property in RiskCategory named "PEP", in Entities, I add IsPoliticallyExposed, in Rules, I create the PEPTradeRule Class, who contains the function IsApplicable that checks and returns if the property IsPoliticallyExposed == true If positive, return the category PEP to class.
In program.cs, I only add the input of the property.

To test PEP:

4000000 Private 10/01/2025 False
5000000 Public 04/02/2020 True
3000000 Public 01/26/2023 True