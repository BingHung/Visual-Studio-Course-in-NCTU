Module Module1


    Public Structure Cap_Struct
        '(1) Inlet properties
        Public In_Temp As Double
        Public In_P, In_vf, In_vg, In_hf, In_hg, In_Viscf, In_Viscg As Double
        Public In_Velocty, In_Re, In_f As Double
        Public In_h, In_v, In_visc As Double
        Public In_x As Double
        '(2) Outlet Properties
        Public Out_Temp As Double
        Public Out_P, Out_vf, Out_vg, Out_hf, Out_hg, Out_Viscf, Out_Viscg As Double
        Public Out_Velocty, Out_Re, Out_f As Double
        Public Out_h, Out_v, Out_visc, Out_s As Double
        Public Out_x As Double
        '(3) Capillary Tube Geometry
        Public Geo_InnerDiameter, Geo_CrossSectionArea As Double
        '(4) Model Asumptions
        Public Influid As String
        Public MFR As Double
        Public w_dividedBy_A As Double
        Public fm As Double
        Public Vm As Double
        Public Section As Double
        Public SectionCout As Double
        Public TubeLength As Double
        Public dL As Double

    End Structure
    Public Cap As New Cap_Struct

    Public Function Cap_getx(ByVal w As Double, ByVal Area As Double, ByVal vg As Double, ByVal vf As Double, ByVal hg As Double, ByVal hf As Double, ByVal V1 As Double, ByVal h1 As Double) As Double
        Dim a, b, c As Double
        a = (vg + vf) ^ 2 * (w / Area) ^ 2 * 0.5
        b = 1000 * (hg - hf) + vf * (vg - vf) * (w / Area) ^ 2
        c = 1000 * (hf - h1) + (w / Area) ^ 2 * 0.5 * vf ^ 2 - V1 ^ 2 / 2
        Return (-b + (b ^ 2 - 4 * a * c) ^ 0.5) / (2 * a)
    End Function

    Public Function TwoPhaseProperties(ByVal f As Double, ByVal g As Double, ByVal x As Double) As Double
        If x < 0 Or x > 1 Then
            'Error Handler
        End If
        Return f * (1 - x) + g * x
    End Function


    Sub Main()
        'Cap_Ver3()
        Cap_Ver4()
    End Sub

End Module
