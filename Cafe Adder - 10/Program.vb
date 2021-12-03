'
' Created by SharpDevelop.
' User: ollie
' Date: 16/10/2021
' Time: 08:07
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim items As Int16 = 0
		Dim VATtext As String = ""
		Dim VAT As Int16 = 0
		Dim takeoutPrice As Double = 0
		Dim pensioneerText As String = ""
		Dim penstioner As Int16 = 0
		Dim name1 As String = ""
		Dim price1 As Double = 0
		Dim items1 As Int16 = 0
		Dim totPrice1 As Double = 0
		Dim name2 As String = ""
		Dim price2 As Double = 0
		Dim items2 As Int16 = 0
		Dim totPrice2 As Double = 0
		Dim name3 As String = ""
		Dim price3 As Double = 0
		Dim items3 As Int16 = 0
		Dim totPrice3 As Double = 0
		Dim name4 As String = ""
		Dim price4 As Double = 0
		Dim items4 As Int16 = 0
		Dim totPrice4 As Double = 0
		Dim name5 As String = ""
		Dim price5 As Double = 0
		Dim items5 As Int16 = 0
		Dim totPrice5 As Double = 0
		Dim VAT10 As Double = 0
		Dim totCost As Double = 0
		Dim newTotCost As Double = 0
		
		Console.WriteLine("CAFE BILL MAKER")
		Console.WriteLine("Hello! Please tell me how many different products there are, 1-5")
		items = Val(Console.ReadLine())
		
		Console.WriteLine("Is the order to take out?, Yes/No")
		VATtext = Console.ReadLine()
		
		If VATtext = "Yes" Or VATtext = "yes" Then
			VAT = 1
		End If
		
		Console.WriteLine("Are you a pensioner?, Yes/No")
		pensioneerText = Console.ReadLine()
		
		If pensioneerText = "Yes" Or pensioneerText = "yes" Then
			penstioner = 1
		End If
		
		If items > 0 And items < 6 Then
			Console.WriteLine("Please enter the name of the first item")
			name1 = Console.ReadLine()
			Console.WriteLine("Please enter the price of the, " & name1 & " in £")
			price1 = Val(Console.ReadLine())
			Console.WriteLine("Please enter how many/much, " & name1 & " you bought.")
			items1 = Val(Console.ReadLine())
		End If
		If items > 1 And items < 6 Then
			Console.WriteLine("Please enter the name of the second item")
			name2 = Console.ReadLine()
			Console.WriteLine("Please enter the price of the, " & name2 & " in £")
			price2 = Val(Console.ReadLine())
			Console.WriteLine("Please enter how many/much, " & name2 & " you bought.")
			items2 = Val(Console.ReadLine())
		End If
		If items > 2 And items < 6 Then
			Console.WriteLine("Please enter the name of the third item")
			name3 = Console.ReadLine()
			Console.WriteLine("Please enter the price of the, " & name3 & " in £")
			price3 = Val(Console.ReadLine())
			Console.WriteLine("Please enter how many/much, " & name3 & " you bought.")
			items3 = Val(Console.ReadLine())
		End If
		If items > 3 And items < 6 Then
			Console.WriteLine("Please enter the name of the fourth item")
			name4 = Console.ReadLine()
			Console.WriteLine("Please enter the price of the, " & name4 & " in £")
			price4 = Val(Console.ReadLine())
			Console.WriteLine("Please enter how many/much, " & name4 & " you bought.")
			items4 = Val(Console.ReadLine())
		End If
		If items > 4 And items < 6 Then
			Console.WriteLine("Please enter the name of the fifth item")
			name5 = Console.ReadLine()
			Console.WriteLine("Please enter the price of the, " & name5 & " in £")
			price5 = Val(Console.ReadLine())
			Console.WriteLine("Please enter how many/much, " & name5 & " you bought.")
			items5 = Val(Console.ReadLine())
		End If
		
		totPrice1 = items1 * price1
		totPrice2 = items2 * price2
		totPrice3 = items3 * price3
		totPrice4 = items4 * price4
		totPrice5 = items5 * price5
		
		totCost = totPrice1 + totPrice2 + totPrice3 + totPrice4 + totPrice5
		
		If VAT = 1 Then
			newTotCost = totCost * 1.2
			takeoutPrice =  newTotCost - totCost
		End If
		
		If penstioner = 1 Then
			VAT10 = totCost / 10
			newTotCost = totCost - VAT10
		End If
		
		Console.Clear()
		
		Console.WriteLine("CAFE BILL RECIEPT")
		Console.WriteLine("")
		Console.WriteLine("Name 		Quantity	Price (£)")
		Console.WriteLine("")
		Console.WriteLine(name1 & "		" & items1 & "		" & price1)
		Console.WriteLine(name2 & "		" & items2 & "		" & price2)
		Console.WriteLine(name3 & "		" & items3 & "		" & price3)
		Console.WriteLine(name4 & "		" & items4 & "		" & price4)
		Console.WriteLine(name5 & "		" & items5 & "		" & price5)
		Console.WriteLine("")
		Console.WriteLine("Takeout price	£" & takeoutPrice)
		Console.WriteLine("Pensoiners discount		£" & VAT10)
		Console.WriteLine("--------------------------------------")
		Console.WriteLine("")
		Console.WriteLine("Total Cost £" & newTotCost)
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module