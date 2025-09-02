Feature: Google Search
  Como usuario
  Quiero buscar en Google
  Para validar que aparece Delinea en los resultados

  Scenario: Buscar Delinea en Google
    Given que estoy en la página de Google
    When busco "Delinea"
    Then debería ver "delinea.com/es" en los resultados