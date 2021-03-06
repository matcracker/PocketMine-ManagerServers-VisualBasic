﻿Module Informations
    ' _____           _        _   __  __ _                   __  __                                   _____                              
    '|  __ \         | |      | | |  \/  (_)                 |  \/  |                                 / ____|                             
    '| |__) |__   ___| | _____| |_| \  / |_ _ __   ___ ______| \  / | __ _ _ __   __ _  __ _  ___ _ _| (___   ___ _ ____   _____ _ __ ___ 
    '|  ___/ _ \ / __| |/ / _ \ __| |\/| | | '_ \ / _ \______| |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__\___ \ / _ \ '__\ \ / / _ \ '__/ __|
    '| |  | (_) | (__|   <  __/ |_| |  | | | | | |  __/      | |  | | (_| | | | | (_| | (_| |  __/ |  ____) |  __/ |   \ V /  __/ |  \__ \
    '|_|   \___/ \___|_|\_\___|\__|_|  |_|_|_| |_|\___|      |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_____/ \___|_|    \_/ \___|_|  |___/
    '                                                                                   __/ |                                             
    '                                                                                  |___/                                              
    'Copyright (C) 2015  matcracker

    'This program is free software: you can redistribute it and/or modify 
    'it under the terms of the GNU Lesser General Public License as published by 
    'the Free Software Foundation, either version 3 of the License, or 
    '(at your option) any later version. 
    Sub Informations(ByVal checklicense As Object, ByRef back As String, ByRef menu4 As String, ByRef info1 As String, ByRef info2 As String, ByRef info3 As String, ByRef info4 As String, ByRef info5 As String, ByRef info6 As String, _
                     ByRef infotitle As String, ByRef infocredits As String, ByRef infoinformations As String, ByRef infodisclaimer As String)

        Dim information, moreinfo, gitlink, twitterlink As String

        gitlink = "https://github.com/matcracker/PocketMine-ManagerServers"

        twitterlink = "https://twitter.com/matcracker98"

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("{0}", infotitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", info1)
            Console.WriteLine("2- {0}", info2)
            Console.WriteLine("3- {0}", info3)
            Console.WriteLine("4- {0}", info4)
            Console.WriteLine("5- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", info5)
            information = Console.ReadLine

            If information = "1" Then

                If checklicense Then
                    Process.Start("C:\Program Files\PocketMine-ManagerServers\LICENSE.pdf")
                Else
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.WriteLine("{0}", info6)
                    Console.ReadLine()
                End If
            End If

            If information = "2" Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.DarkYellow
                Console.WriteLine("{0}", infocredits)
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("This program is free software made by matcracker: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or at your option) any later version.")
                Console.WriteLine()
                Console.WriteLine("This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public License for more details.")
                Console.WriteLine()
                Console.WriteLine("You should have received a copy of the GNU Lesser General Public License along with this program.  If not, see in this program in the section 'Informations ->  License'.")
                Console.WriteLine()
                Console.WriteLine("Press ENTER to go back")
                Console.ReadLine()

            End If

            If information = "3" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkCyan
                    Console.WriteLine("{0}", infoinformations)
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("1- GitHub")
                    Console.WriteLine("2- Twitter")
                    Console.WriteLine("3- {0}", back)
                    Console.WriteLine()
                    Console.Write("{0}", info5)
                    moreinfo = Console.ReadLine

                    If moreinfo = "1" Then
                        Process.Start(gitlink)

                    ElseIf moreinfo = "2" Then
                        Process.Start(twitterlink)

                    End If

                Loop While moreinfo <> "3"
            End If

            If information = "4" Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("========================<PocketMine Manager Servers>============================")
                Console.ForegroundColor = ConsoleColor.DarkBlue
                Console.WriteLine("{0}", infodisclaimer)
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine()
                Console.WriteLine("I do not assume responsibility for the use of this program if being deleted folders or files, for you, important. The use is personal and therefore the connections you supply will have to be primarily related to the creation program server 'PocketMine-MP' or relative.")
                Console.ReadLine()

            End If
        Loop While information <> "5"

    End Sub
End Module
