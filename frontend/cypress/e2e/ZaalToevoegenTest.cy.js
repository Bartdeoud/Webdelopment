describe('Zaal toevoegen test', () => {
  it('Checks if zaal toevoegen is reachable', () => {
    cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
    cy.contains('Menu').click()
    cy.contains('Account').click()
    cy.contains('Klik hier om een zaal toe te voegen').click()
    cy.url().should('include', '/ZaalToevoegen')
  })
})