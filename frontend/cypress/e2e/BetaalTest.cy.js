describe('Betaal test', () => {
    it('Checks if betalen is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket')
        cy.contains('Betaling mislukt').should('be.visible')
        cy.url().should('include', '/ticket')
    })

    it('Checks if url is read correctly (succes)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket?succes=True')
        cy.contains('Betaling gelukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=True')
    })

    it('Checks if url is read correctly (failed)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/ticket?succes=False')
        cy.contains('Betaling mislukt').should('be.visible')
        cy.url().should('include', '/ticket?succes=False')
    })
})