describe('Winkelmand test', () => {
    it('Check if winkelmand is reachable', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('Menu').click()
        cy.contains('Winkelmand').click()
        cy.url().should('include', '/Winkelmand')
        cy.contains('Winkelmand')
    })

    it('Check if winkelmand is empty', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Winkelmand')
        cy.contains('Geen kaarten in winkelmand')
        cy.url().should('include', '/Winkelmand')
    })

    it('Check if winkelmand is full', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/Programma')
        cy.contains('bestel').click()
        cy.get('#SelectedRang').select('Rang 1')
        cy.get('#NumberTickets').type('1')
        cy.contains('Bestel.btn').click()
        cy.wait(1000)
        cy.url().should('include', '/Winkelmand')
        cy.contains('1')
    })
})