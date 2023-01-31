describe('Alternate text test', () => {
    it('Check if alt text is displayed correctly (Hero)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.get('.hero')
            .find('div')
            .should('have.attr', 'alt', 'Theater doek als achtergrond')
    })

    it('Check if alt text is displayed correctly (Hero2)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.get('.hero2')
            .find('div')
            .should('have.attr', 'alt', 'Theater doek als achtergrond')
    })

    it('Check if alt text is displayed correctly (Programma)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.get(':nth-child(2) > .evenementblock > :nth-child(1) > img')
            .should('have.attr', 'alt', 'Afbeelding show')
    })

    it('Check if alt text is displayed correctly (Show)', () => {
        cy.visit('https://salmon-smoke-00d5f3d03.2.azurestaticapps.net/')
        cy.contains('bestel').click()
        cy.get('img')
            .should('have.attr', 'alt', 'Afbeelding show')    
    })
})