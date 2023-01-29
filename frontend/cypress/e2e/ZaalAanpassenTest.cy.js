describe('Zaal aanpassen test', () => {
  it('Checks if zaal aanpassen is reachable', () => {
    cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
    cy.contains('Menu').click()
    cy.contains('Account').click()
    cy.contains('Klik hier om een zaal aan te passen').click()
    cy.url().should('include', '/ZaalAanpassen')
  })

  
  it('Check if zaal aanpassen is working', () => {
    cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ZaalAanpassen')
    cy.contains('Zaal aanpassen').click()
    cy.get('#naam').clear().type('test1')
    cy.get('#rang1').clear().type('1')
    cy.get('#rang2').clear().type('2')
    cy.get('#rang3').clear().type('3')
    // cy.get('#rang4').clear().type('4')
    cy.get('#invalideplaatsen').clear().type('5')
    cy.contains('Aanpassen').click()
    cy.contains('test1')
    
})
})