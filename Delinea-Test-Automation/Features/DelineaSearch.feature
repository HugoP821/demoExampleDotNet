Feature: Google Search
  Como usuario
  Quiero buscar en Google
  Para validar que aparece Delinea en los resultados

  Scenario: Buscar Delinea en Google
    Given que estoy en la p�gina de Google
    When busco "Delinea"
    Then deber�a ver "delinea.com/es" en los resultados