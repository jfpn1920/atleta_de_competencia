Imports System
Module atleta_de_competencia
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim edades(9) As Integer
        Dim deportes(9) As String
        Dim competencias(9) As String
        Dim marcas(9) As Double
        Dim posiciones(9) As Integer
        Dim medallas(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------'
        '--|menu_principal_atleta_de_competencia|--'
        '------------------------------------------'
        Do
            Console.WriteLine("menu principal atleta de competencia")
            Console.WriteLine("1) Registrar atleta")
            Console.WriteLine("2) Editar atleta")
            Console.WriteLine("3) Listar atletas")
            Console.WriteLine("4) Buscar atleta")
            Console.WriteLine("5) Eliminar atleta")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------------------'
                '--|registrar_atleta|--'
                '----------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas atletas.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre del atleta: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Edad: ")
                        edades(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Deporte: ")
                        deportes(cantidad) = Console.ReadLine()
                        Console.Write("Competencia: ")
                        competencias(cantidad) = Console.ReadLine()
                        Console.Write("Marca: ")
                        marcas(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Posicion: ")
                        posiciones(cantidad) = Convert.ToInt32(Console.ReadLine())
                        Console.Write("Medalla: ")
                        medallas(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observacion: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Atleta registrado correctamente.")
                    End If
                '-------------------'
                '--|editar_atleta|--'
                '-------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen atletas registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Edad: " & edades(i) & " | Deporte: " & deportes(i) & " | Competencia: " & competencias(i) & " | Marca: " & marcas(i) & " | Posicion: " & posiciones(i) & " | Medalla: " & medallas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del atleta a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre del atleta: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nueva edad: ")
                            edades(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nuevo deporte: ")
                            deportes(posicion) = Console.ReadLine()
                            Console.Write("Nueva competencia: ")
                            competencias(posicion) = Console.ReadLine()
                            Console.Write("Nueva marca: ")
                            marcas(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva posicion: ")
                            posiciones(posicion) = Convert.ToInt32(Console.ReadLine())
                            Console.Write("Nueva medalla: ")
                            medallas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva observacion: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Atleta actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '--------------------'
                '--|listar_atletas|--'
                '--------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen atletas registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Edad: " & edades(i) & " | Deporte: " & deportes(i) & " | Competencia: " & competencias(i) & " | Marca: " & marcas(i) & " | Posicion: " & posiciones(i) & " | Medalla: " & medallas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                    End If
                '-------------------'
                '--|buscar_atleta|--'
                '-------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen atletas registrados.")
                    Else
                        Console.Write("Ingrese el ID del atleta a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Edad: " & edades(posicion) & " | Deporte: " & deportes(posicion) & " | Competencia: " & competencias(posicion) & " | Marca: " & marcas(posicion) & " | Posicion: " & posiciones(posicion) & " | Medalla: " & medallas(posicion) & " | Estado: " & estados(posicion) & " | Observacion: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|eliminar_atleta|--'
                '---------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen atletas registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Edad: " & edades(i) & " | Deporte: " & deportes(i) & " | Competencia: " & competencias(i) & " | Marca: " & marcas(i) & " | Posicion: " & posiciones(i) & " | Medalla: " & medallas(i) & " | Estado: " & estados(i) & " | Observacion: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del atleta a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                edades(i) = edades(i + 1)
                                deportes(i) = deportes(i + 1)
                                competencias(i) = competencias(i + 1)
                                marcas(i) = marcas(i + 1)
                                posiciones(i) = posiciones(i + 1)
                                medallas(i) = medallas(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Atleta eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen atletas registrados.")
                    Else
                        Dim participando As Integer = 0
                        Dim finalizados As Integer = 0
                        Dim descalificados As Integer = 0
                        Dim retirados As Integer = 0
                        Dim oro As Integer = 0
                        Dim plata As Integer = 0
                        Dim bronce As Integer = 0
                        Dim edadTotal As Integer = 0
                        Dim mejorPosicion As Integer = posiciones(0)
                        Dim peorPosicion As Integer = posiciones(0)
                        Dim atletaMejorPosicion As String = nombres(0)
                        Dim atletaPeorPosicion As String = nombres(0)
                        Dim deporteMasRegistrado As String = deportes(0)
                        Dim mayorDeporte As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            edadTotal += edades(i)
                            If posiciones(i) < mejorPosicion Then
                                mejorPosicion = posiciones(i)
                                atletaMejorPosicion = nombres(i)
                            End If
                            If posiciones(i) > peorPosicion Then
                                peorPosicion = posiciones(i)
                                atletaPeorPosicion = nombres(i)
                            End If
                            Select Case estados(i).ToLower()
                                Case "participando"
                                    participando += 1
                                Case "finalizado"
                                    finalizados += 1
                                Case "descalificado"
                                    descalificados += 1
                                Case "retirado"
                                    retirados += 1
                            End Select
                            Select Case medallas(i).ToLower()
                                Case "oro"
                                    oro += 1
                                Case "plata"
                                    plata += 1
                                Case "bronce"
                                    bronce += 1
                            End Select
                        Next
                        For i As Integer = 0 To cantidad - 1
                            Dim contadorDeporte As Integer = 0
                            For j As Integer = 0 To cantidad - 1
                                If deportes(i).ToLower() = deportes(j).ToLower() Then
                                    contadorDeporte += 1
                                End If
                            Next
                            If contadorDeporte > mayorDeporte Then
                                mayorDeporte = contadorDeporte
                                deporteMasRegistrado = deportes(i)
                            End If
                        Next
                        Dim edadPromedio As Double = edadTotal / cantidad
                        Console.WriteLine("Atletas: " & cantidad & " | Participando: " & participando & " | Finalizados: " & finalizados & " | Descalificados: " & descalificados & " | Retirados: " & retirados & " | Oro: " & oro & " | Plata: " & plata & " | Bronce: " & bronce & " | Mejor posicion: " & atletaMejorPosicion & " | Peor posicion: " & atletaPeorPosicion & " | Edad promedio: " & edadPromedio & " | Deporte mas registrado: " & deporteMasRegistrado)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Atleta de Competencia.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module