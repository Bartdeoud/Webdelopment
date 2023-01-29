describe('404 test', () => {
    it('passes', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/q')
        cy.contains('404').should("be.visible")
        cy.url().should('include', '/q')
        cy.contains('Ga terug naar de home pagina').should("be.visible").click()
        cy.contains('Laaktheater').should("be.visible")
    })
})