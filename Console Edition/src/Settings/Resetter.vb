﻿Module Resetter
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
    Sub Resetter(ByRef nservers As SByte, ByRef checkpath As Object(), ByRef path As String(), ByRef checknservers As Object, ByRef checkfolderinstallation As Object, ByRef dirpath As Object, ByRef dirdata As Object, ByRef dirservername As Object, ByRef dirperformance As Object, ByRef dirinstallations As Object, ByRef dirlanguages As Object, ByRef direrrors As Object, _
                 ByRef back As String, ByRef option2 As String, ByRef resettitle As String, ByRef resetp1 As String, ByRef resetp2 As String, ByRef resetp3 As String, ByRef resetp4 As String, ByRef resetp5 As String, ByRef resetp6 As String, ByRef resetp7 As String, ByRef resetp8 As String, ByRef resetp9 As String, ByRef resetp10 As String, ByRef resetp11 As String)

        Dim choosereset, reset As String

        Do
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("========================<PocketMine Manager Servers>============================")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("{0}", resettitle)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("1- {0}", resetp1)
            Console.WriteLine("2- {0}", resetp2)
            Console.WriteLine("3- {0}", resetp3)
            Console.WriteLine("4- {0}", back)
            Console.WriteLine()
            Console.Write("{0}", resetp4)
            choosereset = Console.ReadLine

            If choosereset = "1" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("{0}", resetp5)
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper
                Loop While reset <> "Y" And reset <> "N"

                If reset = "Y" Then
                    If dirpath And dirservername And dirdata And dirperformance And dirinstallations And dirlanguages And direrrors Then
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Path", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\ServersName", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Data", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Performance", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Installations", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Languages", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers\Backups", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Console.WriteLine("{0}", resetp6)
                        Process.Start("C:\Program Files\PocketMine-ManagerServers\PocketMine-ManagerServers.exe")
                        End
                    Else
                        Console.WriteLine("{0}", resetp7)
                        Console.ReadLine()

                    End If
                End If

            ElseIf choosereset = "2" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("{0}", resetp8)
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper

                    If reset = "Y" Then
                        If checkpath(0) Or checkpath(1) Or checkpath(2) Or checkpath(3) Or checkpath(4) Or checkpath(5) Or checkpath(6) Or checkpath(7) Or checkpath(8) Or checkpath(9) And path(0) <> "" Or path(1) <> "" Or path(2) <> "" Or path(3) <> "" Or path(4) <> "" Or path(5) <> "" Or path(6) <> "" Or path(7) <> "" Or path(8) <> "" Or path(9) <> "" Then
                            If checknservers Then

                                nservers = My.Computer.FileSystem.ReadAllText("C:\Program Files\PocketMine-ManagerServers\Data\servers.pm")

                                For i = 1 To nservers
                                    My.Computer.FileSystem.DeleteDirectory(path(i - 1), path(i - 1), True)

                                Next

                                Console.WriteLine("{0}", resetp6)
                                Process.Start("C:\Program Files\PocketMine-ManagerServers\PocketMine-ManagerServers.exe")
                                End

                            Else
                                Console.WriteLine("{0}", resetp9)
                                Console.ReadLine()

                            End If
                        Else
                            Console.WriteLine("{0}", resetp10)
                            Console.ReadLine()

                        End If
                    End If

                Loop While reset <> "Y" And reset <> "N"

            ElseIf choosereset = "3" Then
                Do
                    Console.Clear()
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("========================<PocketMine Manager Servers>============================")
                    Console.ForegroundColor = ConsoleColor.DarkRed
                    Console.Write("{0}", resetp11)
                    Console.ForegroundColor = ConsoleColor.White
                    reset = Console.ReadLine.ToUpper

                    If reset = "Y" Then
                        If checkfolderinstallation Then
                            My.Computer.FileSystem.DeleteDirectory("C:\Program Files\PocketMine-ManagerServers", FileIO.DeleteDirectoryOption.DeleteAllContents)
                            Console.WriteLine("{0}", resetp6)

                        Else
                            Console.WriteLine("{0}", resetp10)
                            Console.ReadLine()

                        End If

                    End If
                Loop While reset <> "Y" And reset <> "N"

            End If
        Loop While choosereset <> "4"
    End Sub
End Module
